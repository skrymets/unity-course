﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

	public float speed;

	private Rigidbody rb;

	void Start ()
	{

		rb = GetComponent<Rigidbody> ();
		rb.velocity =  Vector3.down * speed;
	}

}
