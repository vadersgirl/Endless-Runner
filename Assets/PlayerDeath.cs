using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
	public string GameOverScene;
	void OnTriggerEnter(Collider other){ 
		GameObject.FindObjectOfType<PlayerScore> ().AccumulatingScore = false;
		UnityEngine.SceneManagement.SceneManager.LoadScene (GameOverScene);
	}
}
