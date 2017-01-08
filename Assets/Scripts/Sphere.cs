using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    private Rigidbody SphereBody;
    public float SpeedX;

	// Use this for initialization
	void Start () {

        SphereBody = gameObject.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.position += new Vector3(SpeedX * Time.deltaTime, 0, 0);
        SpeedX += 0.5f * Time.deltaTime;
		
	}
}
