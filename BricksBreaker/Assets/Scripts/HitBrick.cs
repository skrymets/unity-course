using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBrick : MonoBehaviour
{

	public int maxHits;

	public int prize;

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

		if (currentHit == maxHits) {
			Destroy(gameObject);

			// If there is no bricks left on this scene - go to the next level.
			if (FindObjectsOfType<HitBrick>().GetLength(0) == 0) {
				levelManager.LoadNextLevel();
			}
		}
	}
}