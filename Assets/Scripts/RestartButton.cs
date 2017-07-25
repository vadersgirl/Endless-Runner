using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour {
	public string MainScene;

	public void OnClick ()
	{ 
		try {
			Destroy (GameObject.FindObjectOfType<PlayerScore> ().gameObject);
		} catch (System.Exception ex) {
			
		}

		UnityEngine.SceneManagement.SceneManager.LoadScene (MainScene);
	}
}
