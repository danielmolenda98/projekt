using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screw : MonoBehaviour
{
    public Text pointText;
    int points;
    // Use this for initialization
	void Start ()
    {
        points = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        pointText.text = "Points: " + points;
	}

    public void pointUpdate()
    {
        points++;
    }
}
