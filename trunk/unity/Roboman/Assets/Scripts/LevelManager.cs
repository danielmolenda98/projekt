using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Vector2 currentCheckpoint;
    private PlayerController player;

	// Use this for initialization
	void Start ()
    {
        player = FindObjectOfType <PlayerController> ();
	}
	
    public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        player.transform.position = currentCheckpoint;
    }
}
