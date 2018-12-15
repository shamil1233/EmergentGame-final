using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour {

public GameObject nextButton;
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
		}
	}
}
