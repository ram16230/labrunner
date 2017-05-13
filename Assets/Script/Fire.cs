﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag.Equals ("Player")) {
			other.gameObject.transform.position = new Vector3 (0, 0, 0);
		}
		Destroy (this.gameObject);
	}
}
