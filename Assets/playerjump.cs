using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class playerjump : MonoBehaviour {

	public float jumpforce = 5;
	Rigidbody rb;
	bool grounded;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetButtonDown ("Jump")&& grounded) {
			rb.AddForce (new Vector3 (0, jumpforce, 0), ForceMode.Impulse);
			grounded = false;
		}
		if (CrossPlatformInputManager.GetButtonDown ("Jump") && grounded) {
			rb.AddForce (new Vector3 (0, jumpforce, 0), ForceMode.Impulse);
			grounded = false;
		}
	}
	void OnCollisionEnter(Collision c) {
		grounded = true;
	}
}
	