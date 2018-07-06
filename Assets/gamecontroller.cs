using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour {

	public GameObject pickup;
	public Vector3 spawnValues;

	void Start () {
		StartCoroutine (SpawnWaves ());
	}
	
	void Update () {
		
	}

	IEnumerator SpawnWaves () {
        while (true) {
			yield return new WaitForSeconds (1f);   //wait time

			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
			Instantiate (pickup, spawnPosition, transform.rotation);
        }
    }
}
