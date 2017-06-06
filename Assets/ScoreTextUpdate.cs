using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUpdate : MonoBehaviour {
	Text t;
	PlayerScore player;

	// Use this for initialization
	void Start () {
		t = GetComponent<Text> ();
		player = GameObject.FindObjectOfType<PlayerScore> ();
	}
	
	// Update is called once per frame
	void Update () {
		t.text = "Score: " + Mathf.Round(player.Score);
	}
}