using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Text pointText;
    int point;

    // Use this for initialization
    void Start()
    {
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points: " + point;
    }

    public void pointUpdate()
    {
        point++;
    }
}
