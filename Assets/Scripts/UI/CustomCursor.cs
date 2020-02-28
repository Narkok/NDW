using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CustomCursor : MonoBehaviour
{
    private Animator _anim;

    void Awake()
    {
        Cursor.visible = false;
        gameObject.SetActive(true);

        _anim = GetComponent<Animator>();
        Vector3 curPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        curPos.z = -9;
        transform.position = curPos;
    }

    void Update()
    {
        Vector3 curPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        curPos.z = -9;
        transform.position = curPos;

        if (Input.GetMouseButtonDown(0)) _anim.SetBool("Pressed", true);
        if (Input.GetMouseButtonUp(0)) _anim.SetBool("Pressed", false);
    }
}
