using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 
    }

    private bool zoomFlag = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (!zoomFlag)
            {
                zoomFlag = true;
                transform.Translate(0, -1.5f, 1.5f);
                transform.Rotate(-5, 0, 0);
            }
        }
        else
        {
            if(zoomFlag)
            {
                zoomFlag = false;
                transform.Translate(0, 1.5f, -1.5f);
                transform.Rotate(5, 0, 0);
            }
        }
    }
}
