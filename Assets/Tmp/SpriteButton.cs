using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButton: MonoBehaviour {

    [SerializeField] private Character.Type character;

    private Castle playerCastle;
    private bool clickIsValid = false;
    private Vector3 initialScale;


    private void Awake() {
        playerCastle = FindObjectOfType<PlayerCastle>().GetComponent<Castle>();
        initialScale = transform.localScale;
    }


    private void OnMouseEnter() {
        clickIsValid = true;
        SetAlpha(0.8f);
    }


    private void OnMouseExit() {
        clickIsValid = false;
        SetAlpha(1);
        SetScale(1);
    }


    private void OnMouseDown() {
        SetScale(0.95f);
    }


    private void OnMouseUp() {
        if (clickIsValid) {
            SetScale(1);
            playerCastle.Spawn(character);
        }
    }


    private void SetAlpha(float alpha) {
        Color color = GetComponent<SpriteRenderer>().color;
        color.a = alpha;
        GetComponent<SpriteRenderer>().color = color;
    }


    private void SetScale(float scale) {
        transform.localScale = initialScale * scale;
    }
}
