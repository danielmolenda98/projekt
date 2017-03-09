using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Lifes : MonoBehaviour
{
    public int cur_lives = 3; //current lives

    public Vector3 spawnPoint;
    public RawImage lifeCPU;
    public RawImage lifeCPU1;
    public RawImage lifeCPU2;

    // Update is called once per frame
    void Update ()
    {
        CheckHealth();	
	}

    public void CheckHealth()
    {
        if (cur_lives == 3)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = true;
            lifeCPU2.enabled = true;
        }

        if (cur_lives == 2)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = true;
            lifeCPU2.enabled = false;
        }

        if (cur_lives == 1)
        {
            lifeCPU.enabled = true;
            lifeCPU1.enabled = false;
            lifeCPU2.enabled = false;
        }

        if (cur_lives == 0)
        {
            Debug.Log("GAME OVER!");
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            cur_lives--;
            other.transform.position = spawnPoint;
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
            
        }
    }
}
