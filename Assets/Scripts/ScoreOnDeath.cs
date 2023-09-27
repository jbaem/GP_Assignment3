using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    public int amount;

    private void Awake()
    {
        var life = GetComponent<Life>();
        life.onDeath.AddListener(GivePoints);
    }
    private void Update()
    {
        print("cnt: "+ ScoreManager.instance.amount +"\n");
    }
    void GivePoints()
    {
        ScoreManager.instance.amount += amount;
    }

    private void OnDestroy()
    {
        ScoreManager.instance.amount += amount;
    }
}
