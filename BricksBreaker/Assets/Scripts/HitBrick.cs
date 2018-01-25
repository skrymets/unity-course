using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBrick : MonoBehaviour
{

	public int maxHits;

	public int currentHit = 0;

	private LevelManager levelManager;

	// Use this for initialization
	void Start()
	{
		levelManager = FindObjectOfType<LevelManager>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		currentHit++;
		SimulateWin();
	}

	void SimulateWin()
	{
		levelManager.LoadNextLevel();
	}
}