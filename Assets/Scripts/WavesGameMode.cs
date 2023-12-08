using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] Life playerLife;
    [SerializeField] Life baseLife;
    void Start()
    {
        Invoke("WinLose", 60);
    }

    void Update()
    {
        if(playerLife.amount <= 0 || baseLife.amount <= 0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
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
