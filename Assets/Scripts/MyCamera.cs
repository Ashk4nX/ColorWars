using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour {

    public Sphere sphere;

    private Vector3 spherePos;
    private float camXPos;

	// Use this for initialization
	void Start () {

        spherePos = sphere.transform.position;
        camXPos = gameObject.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

        camXPos = spherePos.x;

	}
}
