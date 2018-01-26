using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {

	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D trigger) {
		Debug.Log("Trigger enter");
	}

	void OnCollisionEnter2D(Collision2D collision) {
		// levelManager.PlayerLose();
		Debug.Log("Player has lost!");
	}

}
