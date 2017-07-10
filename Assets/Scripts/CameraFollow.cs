using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject rock;
	public int FOLLOW_DISTANCE = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		try {
			transform.position = rock.transform.position + (Vector3.up*5);
		} catch {} //rock was destroyed 
	}
}
