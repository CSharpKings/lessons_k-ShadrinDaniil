﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		print ("Координаты:" + "х ="+transform.position.x + " y =" + transform.position.y +  " z =" + transform.position.z);
		
	}
}
