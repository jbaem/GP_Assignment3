using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateParticleSystemWithCamera : MonoBehaviour
{
    public Camera mainCamera;

    // Update is called once per frame
    void Update()
    {
        if(mainCamera != null)
        {
            transform.rotation = Quaternion.Euler(0f, mainCamera.transform.eulerAngles.y, 0f);
        }
    }
}
