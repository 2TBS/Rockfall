using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pl_Input : MonoBehaviour {

    public bool isFlat = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tilt = Input.acceleration;
	}
}
