﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT1 : MonoBehaviour {

bool colCheck;
public Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
 void OnTriggerEnter2D (Collider2D collision)
  {
		if (collision.gameObject.tag == "BreakWall")
		{
		Destroy (gameObject);
		}

  }

}
