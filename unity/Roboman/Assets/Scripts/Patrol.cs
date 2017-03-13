using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour
{
	public Vector3[] patrolPoints;
	public float moveSpeed;
	private int currentPoint;
	// Use this for initialization
	void Start ()
    {
		transform.localScale = new Vector2(transform.localScale.x,transform.localScale.y);
		transform.position = patrolPoints[0];
		currentPoint = 0;
	}
	
	void Update ()
    {
		if(transform.position == patrolPoints[currentPoint])
		{
			transform.localScale = new Vector2(-transform.localScale.x,transform.localScale.y);
			currentPoint++;
		}
		if(currentPoint >= patrolPoints.Length)
		{
			currentPoint = 0;
		}
		transform.position = Vector2.MoveTowards(transform.position,patrolPoints[currentPoint],moveSpeed=Time.deltaTime);
	}
}
