using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		float mousePosInBlocks = Mathf.Clamp(Input.mousePosition.x / Screen.width * 20, 0.667f, 19.333f);
		transform.position = new Vector3(mousePosInBlocks, transform.position.y);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		collision.gameObject.GetComponent<Rigidbody2D>().velocity *= 1.1f;
	}
}
