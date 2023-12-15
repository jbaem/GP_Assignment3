using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.PostProcessing;

public class ZoomPpController : MonoBehaviour
{
    private PostProcessVolume postProcessVolume;
    private Vignette vignette;

    // Start is called before the first frame update
    void Start()
    {
        postProcessVolume = GetComponent<PostProcessVolume>();
        
        if(postProcessVolume != null)
        {
            postProcessVolume.profile.TryGetSettings(out vignette);
        }

    }
    public void OnPowerUp(InputValue value)
    {
        if (value.isPressed)
        {
            EnableVignette();
        }
        else
        {
            DisableVignette();
        }
    }

    public void EnableVignette()
    {
        if(vignette != null)
        {
            vignette.enabled.value = true;
        }
    }
    public void DisableVignette()
    {
        if (vignette != null)
        {
            vignette.enabled.value = false;
        }
    }
}
