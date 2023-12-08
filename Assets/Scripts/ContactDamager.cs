using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    public float damage;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Life life = other.GetComponent<Life>();

            if(life != null)
            {
                life.amount -= damage;
            }
            Destroy(gameObject);
        }

    }
}
