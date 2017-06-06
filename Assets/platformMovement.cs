using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour {
	public float speed = 2; 
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		rb.MovePosition (transform.position - transform.right * speed * Time.deltaTime);

		
	}

	void OnTriggerEnter(Collider c)
	{ 
		if (c.gameObject.tag != "Coin" && c.gameObject.tag != "Player"  ) {
			Destroy (gameObject);
		}
	}
}
