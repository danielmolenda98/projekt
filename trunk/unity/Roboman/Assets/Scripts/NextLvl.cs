using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{
	public int nextlvl;

	void OnCollisionEnter2D(Collision2D other)
    {
		if (other.transform.tag == "Player")
        {
			SceneManager.LoadScene (nextlvl);
		}
	}
}