using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour {

	private FracturedObject fractureWall;

	// Use this for initialization
	void Start () {

		fractureWall = gameObject.GetComponent<FracturedObject> ();

		fractureWall.TotalMass = Random.Range (2,3);

		fractureWall.ChunkConnectionStrength = Random.Range (0.2f, 0.5f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
