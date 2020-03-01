using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerController : MonoBehaviour
{

    private Animator _anim;
    private GameObject _slider;

    private bool isPressed = false;
    private bool isHovered = false;

    void Start()
    {
        _slider = GameObject.Find("Slider");
        _anim = _slider.GetComponent<Animator>();
    }

    void OnMouseEnter()
    {
        isHovered = true;
        _anim.SetBool("Hover", true);
    }

    private void OnMouseDown()
    {
        isPressed = true;
    }

    private void OnMouseExit()
    {
        isHovered = false;
        if (!isPressed)
        {
            _anim.SetBool("Hover", false);
        }
    }

    void OnMouseUp()
    {
        isPressed = false;
        if (!isHovered)
        {
            _anim.SetBool("Hover", false);
        }
    }
}
