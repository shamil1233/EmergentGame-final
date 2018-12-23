using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour {

private PointEffectt pointerEffect;
	void Start () {
		//pointerEffect = GetComponent<PointEffectt>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.B))
		{
			Destroy(gameObject);
		}
		//Destroy(gameObject);
	}
}
