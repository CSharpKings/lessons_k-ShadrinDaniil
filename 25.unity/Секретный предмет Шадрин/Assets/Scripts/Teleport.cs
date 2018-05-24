using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

	float time = 0;
	// Update is called once per frame
	void Update ()
	{

		time = time + Time.deltaTime;
		if (time > 33) {
			transform.position = new Vector3 (-31.8f, 10f, -2.73927f);
			time = 0;
		}

	}
}
