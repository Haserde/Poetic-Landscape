﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Horizontal");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
	}
}