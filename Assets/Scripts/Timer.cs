using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeDisplay;
    public float targetTime = 60f;
    public GameObject Portail1, Portail2, Boss;

    public Timer moi;

    void Update()
    {
        targetTime -= Time.deltaTime;
        
        if (targetTime <= 30f) Portail2.gameObject.SetActive(true);

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

        timeDisplay.text = targetTime.ToString("f0");
    }

    void timerEnded()
    {
        Portail1.gameObject.SetActive(false);
        Portail2.gameObject.SetActive(false);
        
        Boss.gameObject.SetActive(true);
        moi.enabled = false;
    }
    
}
