using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {
	public float Score = 0;
	public float ScorePerSecond = 5;
	public bool AccumulatingScore = true;
	void AddScore(float value){Score += value;
	}
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
		if (AccumulatingScore) 
			AddScore (ScorePerSecond * Time.deltaTime);
	}
}
