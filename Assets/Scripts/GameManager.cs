using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField] private GameObject blackScreen;
    [SerializeField] private GameObject startMenuButtons;
    [SerializeField] private GameObject canvas;
    [SerializeField] private bool skipMenu = false;

    void Awake() {
        blackScreen.SetActive(true);
        blackScreen.GetComponent<Animator>().SetBool("Fade", true);

        startMenuButtons.SetActive(true);
        canvas.SetActive(true);

        if (skipMenu) {
            startMenuButtons.SetActive(false);
            StartGame();
        }
    }


    public void ButtonPressed(Button.Type type) {
        switch (type) {
            case Button.Type.Start: 
                StartGame();
                break;
            
            case Button.Type.Exit:
                ExitGame();
                break;
        }
    }


    void StartGame() {
        Debug.Log("Start");
        startMenuButtons.GetComponent<Animator>().SetBool("Hide", true);
    }


    void ExitGame() {
        Debug.Log("Exit");
        Application.Quit();
    }
}