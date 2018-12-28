using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTDestroy : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "TNT")
		{
			Destroy(gameObject, 3f);
		}
	}
}
