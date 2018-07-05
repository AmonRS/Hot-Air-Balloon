using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class score : MonoBehaviour {

	public Text scoretext;
	float playerscore;

	// Use this for initialization
	void Start () {
		playerscore = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		playerscore = playerscore + (Time.deltaTime*100);
		scoretext.text = "Score: " + Mathf.RoundToInt(playerscore);
	}
}
