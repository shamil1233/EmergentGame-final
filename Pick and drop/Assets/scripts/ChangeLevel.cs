using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour {

public GameObject nextButton;
//private Controller1 Controller1;
//private Jump1 Jump1;
//private Controller2 Controller2;
//private Jump2 Jump2;

	// Use this for initialization
	void Start () {
		nextButton.SetActive(false);
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Cheese")
		{
			nextButton.SetActive(true);
			//Controller1 = GetComponent<Controller1>().enabled = false;
			//Jump1 = GetComponent<Jump1>().enabled = false;
			//Jump2 = GetComponent<Jump2>().enabled = false;
			//Controller2 = GetComponent<Controller2>().enabled = false;


		}
	}
}
