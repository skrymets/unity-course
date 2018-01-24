using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoundary : MonoBehaviour
{
	void OnTriggerExit /** OnTriggerEnter*/ (Collider other)
	{
		if (other.CompareTag ("LaserShot") || other.CompareTag("Asteroid")) {
			Destroy (other.gameObject);
		}
	}
}
