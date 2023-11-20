using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float delay;
    int moveDirection = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Randomizing", 0, 1);
        Invoke("CancelInvoke", delay);
    }
    void Randomizing()
    {
        moveDirection = Random.Range(0, 9);
    }

    public float speed;
    // Update is called once per frame
    void Update()
    {   
        /*
        if (moveDirection == 0) { transform.Translate(0, 0, 0); }
        else if (moveDirection == 1) { transform.Translate(0, speed * Time.deltaTime, 0); }
        else if (moveDirection == 2) { transform.Translate(0, -speed * Time.deltaTime, 0); }
        else if (moveDirection == 3) { transform.Translate(speed * Time.deltaTime, speed * Time.deltaTime, 0); }
        else if (moveDirection == 4) { transform.Translate(-speed * Time.deltaTime, speed * Time.deltaTime, 0); }
        else if (moveDirection == 5) { transform.Translate(-speed * Time.deltaTime, -speed * Time.deltaTime, 0); }
        else if (moveDirection == 6) { transform.Translate(speed * Time.deltaTime, -speed * Time.deltaTime, 0); }
        else if (moveDirection == 7) { transform.Translate(speed * Time.deltaTime, 0, 0); }
        else if (moveDirection == 8) { transform.Translate(-speed * Time.deltaTime, 0, 0); }
         */
    }
}
