using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Text pointsText;
    public GameObject panelgameover;

    public int nextlvl;
    public float time = 2f;
    int cur_points; // current points
    int cur_lifes; // current lifesW

    public RawImage lifeCPU;
    public RawImage lifeCPU1;
    public RawImage lifeCPU2;


    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        cur_points = 0;
        cur_lifes = 3;
    }

    // Update is called once per frame
    public void Update()
    {     
        pointsText.text = "" + cur_points;

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
            lifeCPU.enabled = false;
            lifeCPU1.enabled = false;
            lifeCPU2.enabled = false;

            panelgameover.SetActive(true);
            Time.timeScale = 0;
        }
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

    public void gameover()
    {
        if (cur_lifes == 0)
        {
            Time.timeScale = 0;
            panelgameover.SetActive(true);
        }
    }
}
