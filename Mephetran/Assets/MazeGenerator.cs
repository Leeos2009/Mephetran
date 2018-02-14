using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour {

	public int width = 5;
	public int length = 5;
	private int i, j;
	// Use this for initialization
	void Start () {
		GameObject Wall = new GameObject();
		//Wall.transform.parent(this.transform);
		//mazeCreation();
		for(i = 0; i <= width; i++)
		{
			for(j = 0; j < length; j++)
			{
				Vector3 wallPosition = new Vector3(1 * (i + i) - 2, 1, 1 * (j + j));
				Wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
				Wall.transform.localScale += new Vector3(-0.5f, 0, 1f);
				Wall.name = "AAA";
				Instantiate(Wall, wallPosition, Quaternion.identity);
			}
		}
		for(i = 0; i < width; i++)
		{
			for(j = 0; j <= length; j++)
			{
				Vector3 wallPosition = new Vector3(1 * (i + i) - 1, 1, 1 * (j + j) - 1);
				Wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
				Wall.transform.localScale += new Vector3(-0.5f, 0, 1f);
				//Wall.transform.Rotate += new Vector3(0, 90, 0);
				Instantiate(Wall, wallPosition, Quaternion.Euler(0.0f, 90.0f, 0.0f));
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
