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

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();

		// Input.gyro.enabled = true;
	}

	void FixedUpdate ()
	{

		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical) * speed;
		// Vector3 movement = new Vector3 (Input.gyro.rotationRateUnbiased.y, 0.0f, -Input.gyro.rotationRateUnbiased.x) * speed;

		rb.velocity = movement;

		rb.position = new Vector3 (
			Mathf.Clamp (transform.position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp (transform.position.z, boundary.zMin, boundary.zMax)
		);

		// y = rb.rotation.y * tilt
		rb.rotation = Quaternion.Euler (/** -90.0f **/ 0.0f, movement.x * tilt, movement.x * -tilt);
	}

	void Update ()
	{

	    if (Input.GetKeyDown (KeyCode.Space) && Time.time > nextFireTime) {
		// if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began
		//    && Time.time > nextFireTime) {

			nextFireTime = Time.time + fireRate;
			GameObject clone = Instantiate (shot, shotSpawn.position, shotSpawn.rotation) as GameObject;
		}

	}
}
