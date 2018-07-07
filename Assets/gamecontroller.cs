using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour {

	public GameObject health;
	public GameObject spike;
	public Vector3 spawnValues;

	void Start () {
		StartCoroutine (SpawnHealth());
		StartCoroutine (SpawnSpikes());
	}
	
	void Update () {
		
	}

	IEnumerator SpawnHealth () {
        while (true) {
			yield return new WaitForSeconds (3f);   //wait time

			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
			Instantiate (health, spawnPosition, transform.rotation);
        }
    }

	IEnumerator SpawnSpikes () {
        while (true) {
			yield return new WaitForSeconds (0.7f);   //wait time

			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
			Instantiate (spike, spawnPosition, transform.rotation);
        }
    }
}
