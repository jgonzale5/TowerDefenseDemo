using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour
{
    public Text text;

    public float secondsPassed = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secondsPassed += Time.deltaTime;

        DisplayTime(secondsPassed);
    }

    public void DisplayTime(float seconds)
    {
        int hours = Mathf.FloorToInt(seconds / 3600);
        int minutes = Mathf.FloorToInt(seconds / 60) % 60;
        int secs = Mathf.FloorToInt(seconds % 60);

        //text.text = hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + secs.ToString("D2");

        text.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, secs);
    }
}
