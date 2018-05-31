using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		speed = GetComponent <Speed> ();
	}
	Speed speed;
	float time = 0;
	// Update is called once per frame
	void Update ()
	{
		time = time + Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.Space)||Input.GetKeyDown (KeyCode.Mouse0)) {
			transform.position = new Vector3 (transform.position.x, 2.2f, transform.position.z);
		}
		if (time >= 1) {
			speed.enabled = true;
		}
	}

	void OnTriggerEnter (Collider other)
	{
		transform.position = new Vector3 (0f, 0.424f, 0f); 
		
		speed.enabled = false;
		time = 0;
	}
}

	
