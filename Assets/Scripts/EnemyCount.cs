using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EnemyCount : MonoBehaviour
{
    public TMP_Text myText;
    // Start is called before the first frame update
    void Start()
    {
        CountAndPrintEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        CountAndPrintEnemies();
    }

    void CountAndPrintEnemies()
    {
        int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        myText.text = "x " + enemyCount;
    }
}
