using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWin : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	public Transform cube;
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance (cube.position, transform.position);
		if (dist < 3) {
			print ("Победа!");
		}


	}
}
