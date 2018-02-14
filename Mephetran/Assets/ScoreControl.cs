using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour {
	private int currentScore = 0;
	TextMesh scoreText;
	// Use this for initialization
	void Start () {
	scoreText = GetComponent<TextMesh>();
	scoreText.transform.parent = Camera.main.transform;
	scoreText.transform.position = new Vector3(5.0f, 5.0f, 5.0f);
	scoreText.text = "Score: " + currentScore;
	scoreText.fontSize = 255;
    scoreText.characterSize = .03f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void addScore() {
	scoreText.text = "Score: " + currentScore;
	
	}
}
