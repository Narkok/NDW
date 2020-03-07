using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FocusPointController: MonoBehaviour {

    public float cameraRange = 30;
    public float moonRange = 3.2f;
    public float starsRange = 2;

    private float camPosY, camPosZ;

    Vector3 newMoonPos = new Vector3();
    Vector3 newStarsPos = new Vector3();

    private Transform cam;
    private Transform moon;
    private Transform stars;
    [SerializeField] private Slider slider;


    void Awake()
    {
        camPosY = transform.position.y;
        camPosZ = transform.position.z;

        cam = GameObject.Find("Camera").transform.GetComponent<Transform>();
        moon = GameObject.Find("Moon").transform.GetComponent<Transform>();
        stars = GameObject.Find("Stars").transform.GetComponent<Transform>();
        slider = FindObjectOfType<Slider>();

        newMoonPos = moon.position;
        newStarsPos = stars.position;
    }


    public void ChangePosition(float value) {
        if (transform != null) {
            transform.position = new Vector3(value * cameraRange, camPosY, camPosZ);
        }

        newMoonPos.x = value * moonRange;
        newStarsPos.x = value * starsRange;
    }


    void Update() {
        float LR = Input.GetAxis("Horizontal");
        if (System.Math.Abs(LR) >= 0.01f) {
            slider.value += LR / 60;
        }

        cam.position = Vector3.Lerp(cam.position, transform.position, 2 * Time.deltaTime);
        moon.position = Vector3.Lerp(moon.position, newMoonPos, 2 * Time.deltaTime);
        stars.position = Vector3.Lerp(stars.position, newStarsPos, 2 * Time.deltaTime);
    }
}
