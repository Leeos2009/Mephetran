using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour {

		public int speed = 15;
    private float turningSpeed = 60;
    GameObject Capsule;

    // Use this for initialization
    void Start () {
        Camera.main.transform.parent = this.transform;
      
    }
	
	// Update is called once per frame
	void Update () {
        
        if (shouldMoveForward()) MoveForward();
        if (shouldMoveBackward()) MoveBackward();
        if (shouldRotateLeft()) RotateLeft();
        if (shouldRotateRight()) RotateRight();

		/*if(Input.GetKeyDown(KeyCode.W))
		{
		
		}
        if(Input.GetKeyDown(KeyCode.S))
        {
            this.transform.position += -transform.forward * speed;
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up * 270);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
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

    private void RotateRight()
    {
        this.transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
    }

    private bool shouldRotateRight()
    {
        return (Input.GetKey(KeyCode.D));
    }

    private void RotateLeft()
    {
        this.transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
    }

    private bool shouldRotateLeft()
    {
        return (Input.GetKey(KeyCode.A));
    }

    private bool shouldMoveBackward()
    {
        return (Input.GetKey(KeyCode.S));
    }

    private void MoveBackward()
    {
        this.transform.position += -transform.forward * speed * Time.deltaTime;
    }

    private void MoveForward()
    {
        this.transform.position += transform.forward * speed * Time.deltaTime;
    }

    private bool shouldMoveForward()
    {
        return (Input.GetKey(KeyCode.W));
    }
}
