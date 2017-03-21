using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class LevelSelect : MonoBehaviour
{
    public void LvlSelect(int level)
    {
		SceneManager.LoadScene(level);
	}
	public void Exit()
    {
		Application.Quit();
	}

    public void Inputs()
    {
        if(Input.GetButton("Play"))
        {
            Time.timeScale = 1;
        }
    }
}
