using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour {
	public string MainScene;

	public void OnClick ()
	{ 
		Destroy (GameObject.FindObjectOfType<PlayerScore> ().gameObject);
		UnityEngine.SceneManagement.SceneManager.LoadScene (MainScene);
	}
}
