using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
	public string GameOverScene;
	public AudioSource coinSE;
	void OnTriggerEnter(Collider other){ 
		if (other.gameObject.tag != "Coin") {
			GameObject.FindObjectOfType<PlayerScore> ().AccumulatingScore = false;
			UnityEngine.SceneManagement.SceneManager.LoadScene (GameOverScene);
		} else {
            coinscript c = other.GetComponent<coinscript>();
            GameObject particles = Instantiate<GameObject>(c.coinParticles);
            particles.transform.position = other.transform.position;
            particles.transform.rotation = Quaternion.Euler(Vector3.zero);
            particles.transform.parent = other.transform.parent;
            particles.transform.localScale = Vector3.one ;
            GameObject.FindObjectOfType<PlayerScore> ().Score += c.Score;
            other.gameObject.transform.parent = null;
			coinSE.Play ();
			Destroy (other.gameObject);
		}
	}
}
