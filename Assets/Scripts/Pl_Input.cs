using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pl_Input : MonoBehaviour {

    public bool isFlat = true;

	// Update is called once per frame
	void Update () {
        Vector3 tilt = Input.acceleration;

        transform.Translate(tilt.x, 0, tilt.z); //temporary
	}
}
