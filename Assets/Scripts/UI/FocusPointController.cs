using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FocusPointController : MonoBehaviour
{
    private const float EPSYLON = 0.01f;

    public float cameraRange = 30;
    public float moonRange = 3.2f;
    public float starsRange = 2;

    private float camPosY, camPosZ;

    Vector3 newMoonPos = new Vector3();
    Vector3 newStarsPos = new Vector3();

    [SerializeField] private Transform _cam;
    [SerializeField] private Transform _moon;
    [SerializeField] private Transform _stars;
    [SerializeField] private Slider _slider;

    void Awake()
    {
        camPosY = transform.position.y;
        camPosZ = transform.position.z;

        _cam = GameObject.Find("Camera").transform.GetComponent<Transform>();
        _moon = GameObject.Find("Moon").transform.GetComponent<Transform>();
        _stars = GameObject.Find("Stars").transform.GetComponent<Transform>();

        newMoonPos = _moon.position;
        newStarsPos = _stars.position;
    }

    public void ChangePosition(float value)
    {
        if (transform != null)
        {
            transform.position = new Vector3(value * cameraRange, camPosY, camPosZ);
        }
        newMoonPos.x = value * moonRange;
        newStarsPos.x = value * starsRange;

    }

    void Update()
    {

        float LR = Input.GetAxis("Horizontal");
        if (System.Math.Abs(LR) >= EPSYLON)
        {
            _slider.value += LR / 60;
        }

        _cam.position = Vector3.Lerp(_cam.position, transform.position, 2 * Time.deltaTime);
        _moon.position = Vector3.Lerp(_moon.position, newMoonPos, 2 * Time.deltaTime);
        _stars.position = Vector3.Lerp(_stars.position, newStarsPos, 2 * Time.deltaTime);
    }

}
