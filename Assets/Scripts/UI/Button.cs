using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class ButtonTypeExtention {
    public static string Title(this Button.Type buttonType) {
        switch (buttonType) {
            case Button.Type.Start: { return "Start"; }
            case Button.Type.Exit:  { return "Exit"; }
            default: return "";
        }
    }
}


public class Button : MonoBehaviour {

    public enum Type {
        Start,
        Exit
    }


    private Animator animator;
    private GameObject gameManager;

    [SerializeField] private Type type;

    // Эту штуку удалить надо и нормальным лейблом текст кнопки выставить
    [SerializeField] private Sprite buttonSprite;


    void Awake() {
        animator = GetComponent<Animator>();
        GameObject button = transform.Find("Button").gameObject;
        button.GetComponent<SpriteRenderer>().sprite = buttonSprite;
        gameManager = transform.Find("/Game Manager").gameObject;
    }


    public void OnMouseEnter() {
        animator.SetBool("Hover", true);
    }


    public void OnMouseExit() {
        animator.SetBool("Hover", false);
    }


    public void OnMouseUp() {
        animator.SetBool("Press", false);
    }


    public void OnMouseDown() {
        animator.SetBool("Press", true);
        gameManager.GetComponent<GameManager>().ButtonPressed(type);
    }
}
