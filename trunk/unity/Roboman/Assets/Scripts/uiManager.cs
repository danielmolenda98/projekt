﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Text pointsText;

    public int nextlvl;
    public float time = 2f;

    public GameObject panelGameOver;

    public RawImage lifeCPU;
    public RawImage lifeCPU1;
    public RawImage lifeCPU2;

    int cur_points;
    int cur_lifes;

    // Use this for initialization
    void Start()
    {
        cur_points = 0;
        cur_lifes = 3;
    }

    // Update is called once per frame
    public void Update()
    {     
        pointsText.text = "Points: " + cur_points;

        if (cur_lifes == 3)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = true;
            lifeCPU2.enabled = true;
        }

        if (cur_lifes == 2)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = true;
            lifeCPU2.enabled = false;
        }

        if (cur_lifes == 1)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = false;
            lifeCPU2.enabled = false;
        }

        if (cur_lifes == 0)
        {
            panelGameOver.SetActive(true);
            StartCoroutine(next());
        }
    }
    public IEnumerator next()
    {
        yield return new WaitForSeconds(1f);
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(nextlvl);
    }

    public void pointsUpdate()
    {
        cur_points++;
        if (cur_points == 100)
        {
            cur_lifes++;
        }
    }

    public void lifesUpdate()
    {
        if (cur_lifes > 0)
            cur_lifes--;
    }
}
