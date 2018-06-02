using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Write : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	int number = 0;
	float time = 0;

	// Update is called once per frame
	void Update () 
	{
		time = time + Time.deltaTime;

		if (time >= 3) {
			time = 0;
			number = number + 1;
			print ("Монстры атакуют волна" + " " + number);
		}

	}
}
