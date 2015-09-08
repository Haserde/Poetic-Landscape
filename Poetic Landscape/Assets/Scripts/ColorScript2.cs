using UnityEngine;
using System.Collections;

public class ColorScript2 : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter() {
		gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
	}
}