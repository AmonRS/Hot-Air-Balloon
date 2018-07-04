using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class balloon_player : MonoBehaviour {

	public Rigidbody rb;
	public float speed;

	void Start () {

	}
	
	void Update () {
		
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.2f, 0.0f);
        rb.velocity = movement * speed;
	}
}
