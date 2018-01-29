using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

	public bool AutoPlay;

	private Ball ball;

	// Use this for initialization
	void Start()
	{
		ball = FindObjectOfType<Ball>();

	}

	// Update is called once per frame
	void Update()
	{
		if (AutoPlay)
		{
			// float autoPosInBlocks = Mathf.Clamp( / Screen.width * 20, 0.667f, 19.333f);
			transform.position = new Vector3(ball.transform.position.x, 1.0f);
		}
		else
		{
			float mousePosInBlocks = Mathf.Clamp(Input.mousePosition.x / Screen.width * 20, 0.667f, 19.333f);
			transform.position = new Vector3(mousePosInBlocks, 1.0f);
		}
	}

}
