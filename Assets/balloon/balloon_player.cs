using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary {
    public float xMin, xMax;
}

public class balloon_player : MonoBehaviour {

	Rigidbody rb;
	public float speed;
	public Boundary boundary;
	float y_pos;

	void Start () {
		rb = GetComponent<Rigidbody>();
		y_pos = transform.position.y;
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
        rb.velocity = movement * speed;

		rb.position = new Vector3 (
            Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax), 
            rb.position.y, //y_pos 
            0.0f
        );

		rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.x * -2);
	}

	
}
