using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleFix : MonoBehaviour {

    public Vector3 desiredScale=Vector3.one;

	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(desiredScale.x / transform.parent.localScale.x, desiredScale.y / transform.parent.localScale.y, desiredScale.z / transform.parent.localScale.z);
	}
	
	// Update is called once per frame
	void Update () {
    }
}
