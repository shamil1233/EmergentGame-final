using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Scr : MonoBehaviour {

 public static int scoreValue;
	Text score;
	Text yourScore;
	// Use this for initialization
	void Start () {
		
		score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = scoreValue.ToString();
		PlayerPrefs.SetInt("YourScore", scoreValue); 
	}
}
