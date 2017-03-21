using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject howToPlay;
    private bool paused = false;

    // Use this for initialization
    void Start ()
    {
        howToPlay.SetActive(false);
	}

    public void howPlay()
    {
        howToPlay.SetActive(true);
    }

    public void exit()
    {
        howToPlay.SetActive(false);
    }
}
