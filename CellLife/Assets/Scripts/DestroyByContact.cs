using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{

	public GameObject asteroidExplosion;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Boundaries")) {
			return;
		}

		if (other.gameObject.CompareTag ("LaserShot")) {
			Instantiate(asteroidExplosion, transform.position, transform.rotation);
		}

		if (other.gameObject.CompareTag ("Player")) {
			Instantiate(asteroidExplosion, transform.position, transform.rotation);
		}

		Destroy (other.gameObject);
		Destroy(gameObject);
	}

}
