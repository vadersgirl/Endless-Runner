using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerAfterTime : MonoBehaviour {
    public float Time = 5;
	// Use this for initialization
	void Start () {
        StartCoroutine(OnTimeUp());
	}
	
    IEnumerator OnTimeUp()
    {
        yield return new WaitForSeconds(Time);
        Destroy(gameObject);
    }
}
