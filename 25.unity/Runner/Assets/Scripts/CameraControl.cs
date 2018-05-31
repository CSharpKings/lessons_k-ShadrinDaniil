using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public Transform player;
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x, transform.position.y, transform.position.z); 

	}
}
