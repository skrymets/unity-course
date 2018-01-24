using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

	public GameObject hazard;

	public Vector3 spawnValues;
	public int hazardCount;
	public float startWait;
	public float spawnWait;
	public float waveWait;

	void Start ()
	{
		StartCoroutine (SpawnAsteroids ());
	}
	
	// Update is called once per frame
	IEnumerator SpawnAsteroids ()
	{

		yield return new WaitForSeconds (startWait);

		while (true) {
			yield return new WaitForSeconds (waveWait);
			for (int c = 0; c < hazardCount; c++) {

				Vector3 spawnPosition = new Vector3 (
					                        Random.Range (-spawnValues.x, spawnValues.x), 
					                        spawnValues.y, /**  + Random.Range (-c, c)*/
					                        spawnValues.z
				                        );
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
		}
	}
}
