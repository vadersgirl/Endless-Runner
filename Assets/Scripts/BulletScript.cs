using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
    public float Speed = 10; 
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = new Vector3(Speed, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = null;
        float s = other.GetComponent<coinscript>().Score;
        GameObject.FindObjectOfType<PlayerScore>().Score += s;
        Destroy(other.gameObject);
        Destroy(this.gameObject);
      
    }
}
