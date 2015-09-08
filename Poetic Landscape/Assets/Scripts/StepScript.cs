using UnityEngine;
using System.Collections;

public class changecolor : MonoBehaviour 
{
	public Color[] colors = new Color[6];
	
	void Start()
	{
		colors [0] = Color.cyan;
		colors [1] = Color.red;
		colors [2] = Color.green;
		colors [3] = new Color (255, 165, 0);
		colors [4] = Color.yellow;
		colors [5] = Color.magenta;
	}
	
	//void Update(){

		//gameObject.renderer.material.color = new Color [Random.Range(0, colors.Length)];
	//}
}