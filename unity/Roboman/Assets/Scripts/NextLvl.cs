using UnityEngine;
using System.Collections;

public class NextLvl : MonoBehaviour
{
	public int nextlvl;

	void OnCollisionEnter2D(Collision2D other)
    {
		if (other.transform.tag == "Player")
        {
			Application.LoadLevel (nextlvl);
		}
	}
}