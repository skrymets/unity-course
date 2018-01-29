using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float tilt;
	public Boundary boundary;

	public GameObject shot;
	public Transform shotSpawn;

	public float fireRate;

	private float nextFireTime;

	Rigidbody rb;

	void Start()
	{
		gameObject.transform.rotation.Set(-90.0f, 0.0f, 0.0f, 0.0f);

		rb = GetComponent<Rigidbody>();

		Input.gyro.enabled = true;
	}

	void FixedUpdate()
	{
	}

	void MoveWithKeyboard()
	{

		//float moveHorizontal = Input.GetAxis("Horizontal");
		//float moveVertical = Input.GetAxis("Vertical");

		float moveHorizontal = Input.gyro.rotationRate.y;
		float moveVertical = -Input.gyro.rotationRate.x; // Unbiased

		Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f) * ((Mathf.Abs(speed - 0.0f) < 0.01f) ? 0.01f : speed) / 10.0f;

		gameObject.transform.position = new Vector3(
			Mathf.Clamp(gameObject.transform.position.x + movement.x, boundary.xMin, boundary.xMax),
			Mathf.Clamp(gameObject.transform.position.y + movement.y, boundary.zMin, boundary.zMax),
			0.0f
		);

		Quaternion quat = Quaternion.Euler(-90.0f, moveHorizontal * -tilt, 0.0f);
		gameObject.transform.rotation = quat;

	}

	void Update()
	{

		MoveWithKeyboard();

		//if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFireTime)
		//{
			 if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began
			    && Time.time > nextFireTime) {

			nextFireTime = Time.time + fireRate;
			GameObject clone = Instantiate(shot, shotSpawn.position, shotSpawn.rotation) as GameObject;
		}

	}
}
