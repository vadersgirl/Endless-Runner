using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUpdate : MonoBehaviour {

    Text t;
    PlayerScore player;

    // Use this for initialization
    void Start () {
		t = GetComponent<Text> ();
        player = GameObject.FindObjectOfType<PlayerScore>();
    }
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetInt("High Score", Mathf.Max(Mathf.RoundToInt(player.Score), PlayerPrefs.GetInt("High Score")));
        t.text = "High Score: " + (PlayerPrefs.GetInt("High Score")).ToString();
	}
}
