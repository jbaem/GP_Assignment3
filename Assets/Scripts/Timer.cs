using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private float timerDuration = 60f;
    private float currTime;

    // Start is called before the first frame update
    void Start()
    {
        if (timerText == null)
        {
            timerText = GetComponent<TMP_Text>();
        }
        StartTimer();
    }

    void StartTimer()
    {
        currTime = timerDuration;
        UpdateTimerText();
        InvokeRepeating("UpdateTimer", 0.1f, 0.1f);
    }

    void UpdateTimer()
    {
        currTime -= 0.1f;
        if (currTime <= 0f)
        {
            CancelInvoke("UpdateTimer");
        }
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        if(timerText != null)
        {
            timerText.text = currTime.ToString("F1") + "s";
        }
    }

}
