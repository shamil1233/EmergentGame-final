﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D collision)
  {
		if (collision.gameObject.tag == "Player")
		{
		Destroy (gameObject, 2f);
		}
  }
}
