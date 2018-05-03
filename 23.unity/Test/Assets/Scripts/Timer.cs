using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float time = 0;
	// Update is called once per frame
	void Update () 
	{
		 
		time = time + Time.deltaTime;
		print ((int)time);

	}
}
