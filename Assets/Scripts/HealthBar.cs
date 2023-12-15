using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Life life;

    public float fullHP;
    public float currHP;

    // Start is called before the first frame update
    void Start()
    {
        fullHP = life.amount;
    }

    // Update is called once per frame
    void Update()
    {
        currHP = life.amount;
        GetComponent<Slider>().value = currHP / fullHP;
    }
}
