using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public GameObject prefab;
    public float startTime;
    public float endTime;
    public float spawnRate;
    
    void Start()
    {
        WavesManager.instance.waves.Add(this);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("EndSpawner", endTime);

    }

    public float spawnDistance;
    void Spawn()
    {
        int spawnPosition = Random.Range(0, 5);
        if (spawnPosition == 0) { transform.Translate(0, 0, 0); }
        else if (spawnPosition == 1) { transform.Translate(spawnDistance, 0, 0); }
        else if (spawnPosition == 2) { transform.Translate(-spawnDistance, 0, 0); }
        else if (spawnPosition == 3) { transform.Translate(0, -spawnDistance, 0); }
        else if (spawnPosition == 4) { transform.Translate(0, spawnDistance, 0); }
        Instantiate(prefab, transform.position, transform.rotation);
    }

    void EndSpawner()
    {
        WavesManager.instance.waves.Remove(this);
        CancelInvoke();
    }
}
