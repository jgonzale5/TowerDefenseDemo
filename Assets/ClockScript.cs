using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour
{
    public Text display;

    //For Clock1
    float totalSecondsPassed = 0;

    //For Clock2
    float s = 0;
    int m = 0;
    int h = 0;

    // Update is called once per frame
    void Update()
    {
        Clock1();
    }

    public void Clock1()
    {
        totalSecondsPassed += Time.deltaTime;
        int hours = Mathf.FloorToInt(totalSecondsPassed / 3600);
        int minutes = Mathf.FloorToInt(totalSecondsPassed / 60) % 60;
        int seconds = Mathf.FloorToInt(totalSecondsPassed % 60);
        display.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
        //display.text = hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2");
    }

    public void Clock2()
    {
        s += Time.deltaTime;

        if (s >= 60)
        {
            s -= 60;
            m++;

            if (m >= 60)
            {
                m -= 60;
                h++;
            }
        }

        display.text = string.Format("{0:D2}:{1:D2}:{2:D2}", h, m, Mathf.FloorToInt(s));

    }
}
