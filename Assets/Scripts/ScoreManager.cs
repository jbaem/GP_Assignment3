using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int amount = 0;

    void Awake()
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

}
