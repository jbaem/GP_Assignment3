using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] Life playerLife;
    
    void Start()
    {
        Invoke("WinLose", 60);
    }

    void Update()
    {
    }

    void WinLose()
    {
        if (ScoreManager.instance.amount >= 20)
        {
            SceneManager.LoadScene("WinScreen");
        }
        else
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }
}
