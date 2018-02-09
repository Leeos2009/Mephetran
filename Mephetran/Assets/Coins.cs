using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {
	public int score = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
		void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Coin"))
		{
			other.gameObject.SetActive (false);
			score = score + 100;
		}
	}
}
