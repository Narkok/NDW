using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private Animator _anim;

    [SerializeField] private string WTButton; 
    [SerializeField] private Sprite buttonSprite;
    private GameObject gameManager;

    void Awake()
    {
        _anim = GetComponent<Animator>();
        GameObject button = transform.Find("Button").gameObject;
        button.GetComponent<SpriteRenderer>().sprite = buttonSprite;
        gameManager = transform.Find("/Game Manager").gameObject;
    }

    public void OnMouseEnter()
    {
        _anim.SetBool("Hover", true);
    }

    public void OnMouseExit()
    {
        _anim.SetBool("Hover", false);
    }

    public void OnMouseDown()
    {
        _anim.SetBool("Press", true);
        StartCoroutine(ButtonUnpress());
        gameManager.GetComponent<GameLaunchManager>().ButtonPressed(WTButton);
    }

    public IEnumerator ButtonUnpress()
    {
        yield return new WaitForSeconds(0.2f);
        _anim.SetBool("Press", false);
    }
}
