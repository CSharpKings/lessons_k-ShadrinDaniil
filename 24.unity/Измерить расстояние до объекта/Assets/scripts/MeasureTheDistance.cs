using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureTheDistance : MonoBehaviour {
	public Transform enemy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(enemy.position, transform.position);
		print (dist);

	}
}
