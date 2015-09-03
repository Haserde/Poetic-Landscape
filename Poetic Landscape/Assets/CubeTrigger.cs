using UnityEngine;
using System.Collections;

public class CubeTrigger : MonoBehaviour {
	

	void OnTriggerEnter(){
		GameObject.Find ("GreenCube").SetActive (false);
	}
	
}
