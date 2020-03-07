using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButton: MonoBehaviour {

    [SerializeField] private Character.Type character;

    private Castle playerCastle;
    private bool clickIsValid = false;


    private void Awake() {
        playerCastle = FindObjectOfType<PlayerCastle>().GetComponent<Castle>();
    }


    private void OnMouseEnter() {
        clickIsValid = true;
        SetAlpha(0.9f);
    }


    private void OnMouseExit() {
        clickIsValid = false;
        SetAlpha(1);
    }


    private void OnMouseDown() {
        SetAlpha(0.8f);
    }


    private void OnMouseUp() {
        if (clickIsValid) {
            SetAlpha(0.9f);
            playerCastle.Spawn(character);
        }
    }


    private void SetAlpha(float alpha) {
        Color color = GetComponent<SpriteRenderer>().color;
        color.a = alpha;
        GetComponent<SpriteRenderer>().color = color;
    }
}
