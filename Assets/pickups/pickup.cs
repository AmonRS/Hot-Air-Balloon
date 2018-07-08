using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour {

	Slider fuel;
	
	void Start() {
		fuel = GameObject.Find("Slider").GetComponent<Slider>();

		Destroy(gameObject, 10);   //self destruct object in a while
	}

	void Update() {
		float r = 30*Time.deltaTime;
		transform.Rotate(r,r,r);
		transform.position += Vector3.down * Time.deltaTime * 5f;
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("---> " + other.gameObject.name + "---" + gameObject.name + "-------" + fuel.name);

		if (other.gameObject.name=="ballooon"){
			if (gameObject.tag=="health") {
				fuel.value = +30;
			}
			else if (gameObject.tag=="spike") {
				fuel.value = fuel.value + 5;
			}
			Destroy(gameObject);
		}
    }

}
