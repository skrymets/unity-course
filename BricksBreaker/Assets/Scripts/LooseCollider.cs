using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {

	public LevelManager levelManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D trigger) {
		Debug.Log("Trigger enter");
	}

	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log("Collision enter");
	}

}
