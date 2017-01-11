using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	private Text myText;
	private int ScoreValue;

	// Use this for initialization
	void Start () {
		
		myText = gameObject.GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {

		ScoreValue = ((int)(Time.time * 15));
		myText.text = ScoreValue.ToString();

	}

	public void GetScore ()
	{
	
		ScoreValue += 500;
	
	}
}
