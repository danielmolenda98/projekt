using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Text pointsText;
    public Text cristalText;
    public GameObject panelGameOver;
    public GameObject panelPause;

    private PauseMenu pauseMenu;

    public int nextlvl;
    public float time = 2f;
    int cur_points; // current points
    int cur_lifes; // current lifes
    int cur_cristals;
    
    public RawImage lifeCPU;
    public RawImage lifeCPU1;
    public RawImage lifeCPU2;
    public RawImage lifeCPU3;
    public RawImage lifeCPU4;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Timescale = 1");
        Time.timeScale = 1;
        cur_points = 0;
        cur_cristals = 0;
        cur_lifes = 3;

        pauseMenu = panelPause.GetComponent<PauseMenu>();
    }

    // Update is called once per frame
    public void Update()
    {     
        pointsText.text = "" + cur_points;
        cristalText.text = "" + cur_cristals + " / 5";

        if (cur_lifes == 5)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = true;
            lifeCPU2.enabled = true;
            lifeCPU3.enabled = true;
            lifeCPU4.enabled = true;
        }

        if (cur_lifes == 4)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = true;
            lifeCPU2.enabled = true;
            lifeCPU3.enabled = true;
            lifeCPU4.enabled = false;
        }

        if (cur_lifes == 3)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = true;
            lifeCPU2.enabled = true;
            lifeCPU3.enabled = false;
            lifeCPU4.enabled = false;
        }

        if (cur_lifes == 2)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = true;
            lifeCPU2.enabled = false;
            lifeCPU3.enabled = false;
            lifeCPU4.enabled = false;
        }

        if (cur_lifes == 1)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = false;
            lifeCPU2.enabled = false;
            lifeCPU3.enabled = false;
            lifeCPU4.enabled = false;
        }

        if (cur_lifes == 0)
        {
            lifeCPU.enabled = false;
            lifeCPU1.enabled = false;
            lifeCPU2.enabled = false;
            lifeCPU3.enabled = false;
            lifeCPU4.enabled = false;

            panelGameOver.SetActive(true);
            Time.timeScale = 0;
            pauseMenu.isDead = true;
        }
    }

    public void pointsUpdate()
    {
        cur_points++;
        if (cur_points % 100 == 0)
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
            panelGameOver.SetActive(true);
        }
    }

    public void cristalsUpdate()
    {
            cur_cristals++;
    }
}
