using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackWall : MonoBehaviour {

	private Sphere sphere;
	public Light light;

	// Use this for initialization
	void Start () {

		sphere = GameObject.FindObjectOfType<Sphere> ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider Target)
	{
		if (Target.tag == "Sphere") {

			Time.timeScale = 0.2f;
			sphere.isBlackholeEntered = true;
			light.color = Color.black;
		}
	}

	void OnTriggerExit (){
	
		Time.timeScale = 1f;

	}
}
