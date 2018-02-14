using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour {

	public int width = 5;
	public int length = 5;
	// Use this for initialization
	void Start () {
		GameObject Wall = new GameObject();
		//mazeCreation();
		for(int i = 0; i <= width; i++)
		{
			for(int j = 0; j <= length; j++)
			{
				Vector3 wallPosition = new Vector3(1 * i, 1, 1 * j);
				Wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
				Wall.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
				Instantiate(Wall, wallPosition, Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/*public mazeCreation() {
		GameObject cube = new GameObject();
		for(int i = 0; i <= width; i++)
		{
			for(int j = 0; j <= length; j++)
			{
				Vector3 wallPosition = new Vector3(1 * i, 0, 1 * j);
				Wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
				Wall.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
				Instantiate(Wall, wallPosition, Quaternion.identity);
			}
		}
	}*/
}
