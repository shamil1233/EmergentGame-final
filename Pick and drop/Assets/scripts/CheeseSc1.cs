using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSc1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collision)
  {
		if (collision.gameObject.tag == "Player2")
		{
		Destroy (gameObject);
		Player2Scr.scoreValue =+ 1;
		
		}
  }
}
