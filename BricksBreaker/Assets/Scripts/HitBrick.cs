using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBrick : MonoBehaviour
{
	public int prize;

	public Sprite[] hitSprites;

    public AudioClip crackAudio;

	private int currentHit = 0;
    private LevelManager levelManager;
	private ScoreManager scoreManager;

	// Use this for initialization
	void Start()
	{
		levelManager = FindObjectOfType<LevelManager>();
		scoreManager = FindObjectOfType<ScoreManager>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		currentHit++;
		int maxHits = hitSprites.Length + 1;
		if (currentHit >= maxHits)
		{
            AudioSource.PlayClipAtPoint(crackAudio, this.transform.position);

			scoreManager.Earn(prize);
            Destroy(gameObject);

            // If there is no bricks left on this scene - go to the next level.
            if (FindObjectsOfType<HitBrick>().Length == 0)
			{
				levelManager.LoadNextLevel();
			}
		}
		else
		{
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[currentHit - 1];
		}
	}
}