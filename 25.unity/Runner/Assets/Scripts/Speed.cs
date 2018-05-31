using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= 0.424){
			Rigidbody body = GetComponent<Rigidbody>();
			body.velocity = new Vector3(-6, 0, 0);
		}
	}
}