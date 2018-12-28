using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour {

	
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "BreakWall")
		{
			Destroy(gameObject, 3f);
		}
	}
}
