using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WavesManager : MonoBehaviour
{
    public static WavesManager instance;
    public UnityEvent onChanged;

    public List<WaveSpawner> waves;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            print("Duplicated ScoreManager, ignoring this one");
            Debug.Log("Duplicated ScoreManager, ignoring this one", gameObject);
            Debug.LogError("Duplicated ScoreManager, ignoring this one");
        }
    }

    public void AddWave(WaveSpawner wave)
    {
        waves.Add(wave);
        onChanged.Invoke();
    }
    public void RemoveWave(WaveSpawner wave)
    {
        waves.Remove(wave);
        onChanged.Invoke();
    }
}
