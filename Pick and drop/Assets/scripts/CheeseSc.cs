using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collision)
  {
		if (collision.gameObject.tag == "Player")
		{
		Destroy (gameObject);
		Player1Scr.scoreValue =+ 1;
		
		}
  }
}
