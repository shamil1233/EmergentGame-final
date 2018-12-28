using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEffector : MonoBehaviour {

	public GameObject explosion;
	void Update () {
		if(Input.GetKeyDown(KeyCode.B))
		{
			Instantiate(explosion, transform.position, Quaternion.identity);
			gameObject.SetActive(false);

			
		}
	}
}
