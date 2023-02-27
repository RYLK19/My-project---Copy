using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    private float StartTime;
    // Start is called before the first frame update
    void Start()
    {
        StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - StartTime;

        string minutes = ((int)t / 60).ToString();
        string secounds = (t % 60).ToString("f1");

        TimerText.text = minutes + ":" + secounds;
    }
}
