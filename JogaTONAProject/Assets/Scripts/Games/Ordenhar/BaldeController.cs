using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaldeController : MonoBehaviour {

	private Vector2 amplitude = new Vector2 (350, 0);
	private Rigidbody2D balde;

	// Use this for initialization
	void Start () {
		balde = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Mathf.Sin (Time.time) * Time.deltaTime * amplitude.x;
		balde.velocity = new Vector2 (x, 0);
	}
}
