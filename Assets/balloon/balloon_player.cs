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
	float hor;

	void Start () {
		rb = GetComponent<Rigidbody>();
		y_pos = transform.position.y;
		speed = 5;
	}

	void FixedUpdate(){

		/*RaycastHit hit;

		for (int i = 0; i < Input.touchCount; i++){
			if (Input.GetTouch(i).phase == TouchPhase.Stationary || Input.GetTouch(i).phase == TouchPhase.Moved){
				//Debug.Log(Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position).x);

				if (Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position).x > 0) {
					hor = 1;
				}
				else if (Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position).x < 0) {
					hor = -1;
				}
			}
		}*/

		float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);   // (hor, 0.0f, 0.0f);
        rb.velocity = movement * speed;   // * Time.deltaTime;

		rb.position = new Vector3 (
            Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax), 
            rb.position.y,   //y_pos 
            0.0f
        );

		rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.x * -2);

		//hor=0;

	}	
}
