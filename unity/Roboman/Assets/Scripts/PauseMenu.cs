using System.Collections;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUI;
    private bool paused = false;
    public bool isDead = false;

    void Start()
    {
        PauseUI.SetActive(false);
    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }		

        if(paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
        
        if (!paused && !isDead)
        {
            PauseUI.SetActive(false);
                Time.timeScale = 1;
        }
	}

    public void Resume()
    {
        paused = false;
    }

    public void Restart()
    {
        isDead = false;
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
