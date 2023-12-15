using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    public TMP_Text myText;
    public HealthBar hpbar;

    // Update is called once per frame
    void Update()
    {
        string newText = hpbar.currHP + " / " + hpbar.fullHP;
        myText.text = newText;
    }
}
