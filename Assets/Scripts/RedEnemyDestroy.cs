using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemyDestroy : MonoBehaviour
{
    public Life life;

    // Update is called once per frame
    void Update()
    {
        if(life.amount <= 0)
        {
            Destroy(gameObject);
        }
    }
}
