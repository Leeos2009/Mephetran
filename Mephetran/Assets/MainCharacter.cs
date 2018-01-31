using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour {

		public int health = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Character Move Left
		if(Input.GetKeyDown(KeyCode.A))
		{
			this.transform.position += new Vector3(1,0,0);
		}
		//Character Move Right
		if(Input.GetKeyDown(KeyCode.D))
		{
			this.transform.position += new Vector3(-1,0,0);
		}
		//Character Move Forward
		if(Input.GetKeyDown(KeyCode.W))
		{
			this.transform.position += new Vector3(0,0,1);
		}
		//Character Move Backward
		if(Input.GetKeyDown(KeyCode.S))
		{
			this.transform.position += new Vector3(0,0,-1);
		}
		/*if(Input.GetKeyDown(KeyCode.Space))
		{
			this.transform.position += new Vector3(0, 50 * Time.deltaTime, 0);
		}*/
	}
}
