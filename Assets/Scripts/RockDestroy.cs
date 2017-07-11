using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDestroy : MonoBehaviour {


	public GameObject fragments;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*void OnCollisionEnter(Collision col) {
		Debug.Log("collide");
		
		Instantiate(fragments, transform.position, transform.rotation);
		Destroy(gameObject);
	}*/
}
