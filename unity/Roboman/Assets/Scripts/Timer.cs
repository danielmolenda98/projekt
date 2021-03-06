﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float startTime;
    public Text timerText;

    // Use this for initialization
    void Start ()
    {
        startTime = Time.time;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("F2");

        timerText.text = "Time: " + minutes + ":" + seconds;
	}
}
