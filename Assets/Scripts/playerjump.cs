using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class playerjump : MonoBehaviour {

	public float jumpforce = 5;
	Rigidbody rb;
	int jumps;
    public int maxJumps = 2;
    public GameObject Bullet, BulletNode, groundParticles;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject b = Instantiate<GameObject>(Bullet);
            b.transform.position = BulletNode.transform.position;
        }

		if ((CrossPlatformInputManager.GetButtonDown("Jump") || Input.GetButtonDown ("Jump"))&& jumps<maxJumps) {
			rb.AddForce (new Vector3 (0, jumpforce, 0), ForceMode.Impulse);
			jumps++;
		}

	}
	void OnCollisionEnter(Collision c) {
        GameObject g = Instantiate<GameObject>(groundParticles);
        g.transform.position = c.contacts[0].point;
        g.transform.localScale = c.transform.localScale;
        g.transform.parent = c.transform;
        jumps = 0;
	}
}
	