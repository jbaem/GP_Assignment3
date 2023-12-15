using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ZoomInOut : MonoBehaviour
{
    private bool zoomFlag = false;
    public GameObject postProcessingProfile;

    void Start()
    {
        postProcessingProfile.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (!zoomFlag)
            {
                zoomFlag = true;
                transform.Translate(0, -1.5f, 1.5f);
                transform.Rotate(-5, 0, 0);
                postProcessingProfile.SetActive(true);
            }
        }
        else
        {
            if (zoomFlag)
            {
                zoomFlag = false;
                transform.Translate(0, 1.5f, -1.5f);
                transform.Rotate(5, 0, 0);
                postProcessingProfile.SetActive(false);
            }
        }
    }
}
