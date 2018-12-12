using System.Collections;
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
		if (collision.gameObject.tag == "TNT")
		{
		Destroy ();
		}

  }


  void Destroy()
  {
	  Destroy(gameObject, 2f);
  }

 void Update()
 {	
		if(gameObject.tag == "TNT" && Vector2.Distance(transform.position, player.position) < 0.3) 
		{
		  colCheck = true;
		  if(colCheck)
		  {
			 Destroy();
		  }
		}
		else if (colCheck == false)
		{
			CancelInvoke("Destroy");
		}
 }
}
