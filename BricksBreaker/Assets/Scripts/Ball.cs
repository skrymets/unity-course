
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	private Paddle paddle;

	private Vector3 paddleToBallVector;

	private bool gameStarted;

	// Use this for initialization
	void Start()
	{
		paddle = FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}


	// Update is called once per frame
	void Update()
	{
		if (!gameStarted)
		{
			this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetMouseButtonDown(0))
			{
				gameStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-5f, 5.01f), 15f);
			}
		}

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (gameStarted)
		{
			Vector2 tweak = new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(0f, 2.5f));
			GetComponent<Rigidbody2D>().velocity += tweak;
		}
	}

}