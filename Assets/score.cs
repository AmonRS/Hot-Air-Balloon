using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class score : MonoBehaviour {

	public Text scoretext;
	public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoretext.text = "Score: " + (player.position.y*50).ToString("0");
	}
}
