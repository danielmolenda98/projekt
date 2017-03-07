using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public Vector3 spawnPoint;

	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.tag == "Gracz") {
			other.transform.position=spawnPoint;
		}
	
	}
}