using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameCountdown : MonoBehaviour {
	public Text countdownText;
	public int countdownValue = 3;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
		StartCoroutine (tickDown ());
	}

	IEnumerator tickDown()
	{
		while (countdownValue > 0) {
			yield return new WaitForSecondsRealtime (1);
			countdownValue--; //countdownValue = countdownValue - 1;
			countdownText.text = countdownValue.ToString();
		}
		countdownText.gameObject.SetActive (false);
		Time.timeScale = 1;
	}
}
