﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpLeft : MonoBehaviour {

public GameObject prefab1;
	
	// Update is called once per frame
	public float spawnRate;
	float nextSpawn;

	int spawnPrefabs;
	float randX;
	Vector2 spawnPosition;

	public void Start()
	{
		Invoke("Update", 4f);
	}
	void Update () 
	{
		if (Time.time > nextSpawn)
		{
			
			Debug.Log(spawnPrefabs);
			switch (spawnPrefabs)
			{
			case 1: 
				Instantiate (prefab1, transform.position, Quaternion.identity);
				break;
			}
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range(-17.5f, -17f);
			spawnPosition = new Vector2 (randX, transform.position.y);
			Instantiate(prefab1, spawnPosition, Quaternion.identity);


		}
	}
}
