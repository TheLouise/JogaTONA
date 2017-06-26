using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour {

	public Vector3 movement;

	void Start(){
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (movement * Time.deltaTime);
		
	}
}
