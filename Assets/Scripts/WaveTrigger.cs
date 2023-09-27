using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveTrigger : MonoBehaviour
{
    public GameObject waveSpawner;

    GameObject wave1, wave2;
    private void OnDestroy()
    {
        waveSpawner.transform.position = this.transform.position;
        wave1 = Instantiate(waveSpawner);
        wave1.transform.Translate(10, -0.5f, 0);
        wave2 = Instantiate(waveSpawner);
        wave2.transform.Translate(-20, 0, 0);
    }
}
