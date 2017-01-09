using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableCube : MonoBehaviour {

	private Rigidbody CubeBody;
	private Vector3 Force;

	// Use this for initialization
	void Start () {

		CubeBody = gameObject.GetComponent<Rigidbody> ();
		Force = new Vector3 (4f, 0f, 4f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider Target){

		if (Target.tag != "MainGround") {

			CubeBody.AddForce (Force, ForceMode.Impulse);

		}

	}

}
