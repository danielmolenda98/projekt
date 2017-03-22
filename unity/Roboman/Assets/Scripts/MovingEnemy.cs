using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : Enemy
{
    public Vector2 destinationPoint;
    private Vector2[] destinationsPoints;
    public float moveSpeed;
    private int currentPoint;

    // Use this for initialization
    void Start()
    {
        destinationsPoints = new Vector2[2];
        destinationsPoints[0] = transform.position;
        destinationsPoints[1] = new Vector2(transform.position.x + destinationPoint.x, transform.position.y + destinationPoint.y);
        currentPoint = 0;
 
        if (destinationPoint.x > 0)
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }

    void Update()
    {
        if (new Vector2(transform.position.x, transform.position.y) == destinationsPoints[currentPoint])
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            currentPoint++;
        }
        if (currentPoint >= destinationsPoints.Length)
        {
            currentPoint = 0;
        }
        transform.position = Vector2.MoveTowards(transform.position, destinationsPoints[currentPoint], moveSpeed = Time.deltaTime);
    }
}
