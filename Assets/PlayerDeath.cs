using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
	public string GameOverScene;
	void OnTriggerEnter(Collider other){ 
		if (other.gameObject.tag != "Coin") {
			GameObject.FindObjectOfType<PlayerScore> ().AccumulatingScore = false;
			UnityEngine.SceneManagement.SceneManager.LoadScene (GameOverScene);
		} else {
			GameObject.FindObjectOfType<PlayerScore> ().Score += other.GetComponent<coinscript> ().Score;
            other.gameObject.transform.parent = null;
			Destroy (other.gameObject);
		}
	}
}
