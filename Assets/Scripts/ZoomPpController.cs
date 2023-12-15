using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class ZoomPpController : MonoBehaviour
{
    public GameObject postProcessingVolume;
    private void Awake()
    {
        postProcessingVolume.SetActive(false);       
    }

    // Start is called before the first frame update
    public void OnPowerUp(InputValue value)
    {
        if (value.isPressed)
        {
            postProcessingVolume.SetActive(true);
        }
        else
        {
            postProcessingVolume.SetActive(false);
        }
    }
}
