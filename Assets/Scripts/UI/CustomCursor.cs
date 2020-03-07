using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CustomCursor: MonoBehaviour {

    private Animator animator;


    void Awake() {
        /// Убрать системный курсор и показать игровой
        Cursor.visible = false;
        gameObject.SetActive(true);

        animator = GetComponent<Animator>();
    }


    void Update() {
        Vector3 curPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        curPos.z = -9;
        transform.position = curPos;

        if (Input.GetMouseButtonDown(0)) animator.SetBool("Pressed", true);
        if (Input.GetMouseButtonUp(0))   animator.SetBool("Pressed", false);
    }
}
