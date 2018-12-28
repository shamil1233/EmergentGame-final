using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTDeath : MonoBehaviour {

  //public float speed;
	public Transform player;
	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("TNT").GetComponent<Transform>();
	}
	// Update is called once per frame
	//void Update ()
	//{
         void OnTriggerEnter2D(Collider2D col){

		if(col.gameObject.tag == "TNT" && Vector2.Distance(transform.position, player.position) < 2 ) 
		{
		   Destroy(gameObject, 3f);
		}
		}
		
	//}
}
