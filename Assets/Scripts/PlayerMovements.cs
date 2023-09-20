using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public float speed;
    public float rotationSpeed;
    public float dashDistance;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            if(Input.GetKey(KeyCode.Mouse1))
            {
                transform.Translate(0, 0, speed * Time.deltaTime / 2);
            }
            else if(Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(0, 0, speed * Time.deltaTime * 2);
            }
            else
            {
                transform.Translate(0, 0, speed * Time.deltaTime);
            }
            if(Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate(0, 0, dashDistance);
            }
        }
        if (Input.GetKey(KeyCode.S)) {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                transform.Translate(0, 0, -speed * Time.deltaTime / 2);
            }
            else if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(0, 0, -speed * Time.deltaTime * 2);
            }
            else
            {
                transform.Translate(0, 0, -speed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate(0, 0, -dashDistance);
            }
        }
        if (Input.GetKey(KeyCode.A)) {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                transform.Translate(-speed * Time.deltaTime / 2, 0, 0);
            }
            else if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(-speed * Time.deltaTime * 2, 0, 0);
            }
            else
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate(-dashDistance, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.D)) {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                transform.Translate(speed * Time.deltaTime / 2, 0, 0);
            }
            else if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(speed * Time.deltaTime * 2, 0, 0);
            }
            else
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate(dashDistance, 0, 0);
            }
        }
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);
    }
}
