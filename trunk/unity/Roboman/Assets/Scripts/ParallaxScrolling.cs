using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    public Transform cameraTransform; //bieżąca pozycja
    public float parallaxFactor; //współczynnik paralaksy

    private Vector3 prevCameraPosition; // poprzednia pozycja kamery
    private Vector3 deltaCameraPosition; // różnica między poprzednią, a bierzącą pozycją kamery

	// Use this for initialization
	void Start ()
    {
        prevCameraPosition = cameraTransform.position;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        deltaCameraPosition = cameraTransform.position - prevCameraPosition;
        Vector3 parallaxPosition = new Vector3(transform.position.x + (deltaCameraPosition.x * parallaxFactor), transform.position.y, transform.position.x);
        transform.position = parallaxPosition;
        prevCameraPosition = cameraTransform.position;
	}
}
