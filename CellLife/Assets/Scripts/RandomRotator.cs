﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

	private Rigidbody rb;

	public float tumble;

	void Start () {
		rb = GetComponent<Rigidbody>();
		// rb.angularVelocity = Random.rotation.eulerAngles;
		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
