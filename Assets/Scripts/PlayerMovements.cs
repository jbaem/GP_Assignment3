using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    
    public float speed;
    public float rotationSpeed;
    public float dashDistance;

    private Vector2 movementValue;
    private float lookValue;
    private float speedUpValue = 1.0f;
    private bool powerUpValue = false;

    private Rigidbody rb;
    
    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }
    
    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }

    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }
    
    public void OnSpeedUp(InputValue value)
    {
        if(value.isPressed) { speedUpValue = 2; }
        else { speedUpValue = 1; }
    }
    public void OnPowerUp(InputValue value)
    {
        if(value.isPressed) { powerUpValue = true; }
        else { powerUpValue = false; }
    }

    void Update()
    {
        float teleport = Input.GetKeyDown(KeyCode.Space) ? 1 : 0;

        transform.Translate(
            movementValue.x * (Time.deltaTime * (powerUpValue ? 0.5f : speedUpValue) + dashDistance * teleport),
            0,
            movementValue.y * (Time.deltaTime * (powerUpValue ? 0.5f : speedUpValue) + dashDistance * teleport));
        transform.Rotate(0, lookValue * Time.deltaTime, 0);

        rb.AddRelativeForce(
            movementValue.x * Time.deltaTime,
            0,
            movementValue.y * Time.deltaTime);
        rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);
    }
}
