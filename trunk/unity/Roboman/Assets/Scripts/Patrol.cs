using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {

	public Transform[] patrolPoints;
	public float moveSpeed;
	private int currentPoint;
	// Use this for initialization
	void Start () {
		transform.localScale = new Vector2(transform.localScale.x,transform.localScale.y);
		transform.position=patrolPoints[0].position;
		currentPoint=0;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position == patrolPoints[currentPoint].position)
		{
			transform.localScale = new Vector2(-transform.localScale.x,transform.localScale.y);
			currentPoint++;
		}
		if(currentPoint >= patrolPoints.Length)
		{
			currentPoint=0;
		}
		transform.position = Vector2.MoveTowards(transform.position,patrolPoints[currentPoint].position,moveSpeed=Time.deltaTime);
	}
}
