using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{

	public GameObject explosion;
	public AudioClip explosionAudio;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Boundaries"))
		{
			return;
		}

		if (other.gameObject.CompareTag("LaserShot"))
		{
			GameObject particles = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
			Destroy(particles, 2);
		}

		if (other.gameObject.CompareTag("Player"))
		{
			GameObject particles = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
			Destroy(particles, 2);
		}

		AudioSource.PlayClipAtPoint(explosionAudio, this.transform.position);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}

}
