using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider Target)
	{
		if (Target.tag == "Sphere") {

			Time.timeScale = 0.2f;
		
		}
	}

	void OnTriggerExit (){
	
		Time.timeScale = 1f;

	}
}
