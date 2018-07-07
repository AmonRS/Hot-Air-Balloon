using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Decay : MonoBehaviour {

	public Slider fuel;

	// Use this for initialization
	void Start () {
		fuel.value=30f;
	}
	
	// Update is called once per frame
	void Update () {
		fuel.value-=Time.deltaTime;
		//Debug.Log(fuel.value);

		//////////////
		//if value=0, die
		if (fuel.value == 0f) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
