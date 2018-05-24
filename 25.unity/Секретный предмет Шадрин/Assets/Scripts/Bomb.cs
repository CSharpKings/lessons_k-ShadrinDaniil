using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public Transform player;
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance (player.position, transform.position);
		if (dist < 2) {
			player.position = new Vector3 (-31.8f, 2.040581f, -2.73927f);

		}
	}
}
