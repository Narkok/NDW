using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLaunchManager : MonoBehaviour
{
    [SerializeField] private GameObject blackScreen;
    [SerializeField] private GameObject moon;
    [SerializeField] private GameObject startMenuButtons;
    [SerializeField] private GameObject canvas;

    void Awake()
    {
        blackScreen.SetActive(true);
        canvas.SetActive(true);
        blackScreen.AnimatedHide();
    }

    public void ButtonPressed(string WTButton)
    {
        if (WTButton == "Start") { StartGame(); }
        if (WTButton == "Exit") { ExitGame(); }
    }

    void StartGame()
    {
        Debug.Log("Start");
        moon.GetComponent<Animator>().SetBool("MoonDown", true);
        //startMenuButtons.GetComponent<Animator>().SetBool("Hide", true);
        //StartCoroutine(HideObject(startMenuButtons, false));
    }

    void ExitGame()
    {
        Debug.Log("Exit");
    }
}

public static class GameObjectExtension
{
    /// <summary>
    /// Эта штука должна анимированно скрывать объект, но я пока хз, как это сделать
    /// </summary>
    public static void AnimatedHide(this GameObject gameObject)
    {
        gameObject.SetActive(false);
        // MonoBehaviour.StartCoroutine(HideObject(gameObject, isHidden));
    }

    public static void AnimatedShow(this GameObject gameObject)
    {
        gameObject.SetActive(true);
        // MonoBehaviour.StartCoroutine(HideObject(gameObject, isHidden));
    }

    public static IEnumerator HideObject(GameObject gameObject, bool isHidden)
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(!isHidden);
    }
}