using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggercollision : MonoBehaviour {

	public GameObject fuelTank; // = new GameObject();
	public Slider fuel;

	void OnTriggerEnter(Collider other) {
		Debug.Log("---> " + other.tag);

		GameObject collidingobject = other.gameObject;
		if (collidingobject.name=="ballooon"){
			Destroy(fuelTank);
			fuel.value=+30;
			
			//return true;
		}
		//return false;
        // if (other.tag == "Boundary")
        // {
        //     return;
        // }
        //Destroy(other.gameObject);
        //Destroy(gameObject);
    }

}
