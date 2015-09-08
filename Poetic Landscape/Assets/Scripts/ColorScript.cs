using UnityEngine;
using System.Collections;

public class ColorScript : MonoBehaviour {

	void OnTriggerEnter() {
		gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;

		//gameObject.SetActive (true);
	}

	//void OnTriggerExit() {
		//gameObject.SetActive (false);
	//}
}