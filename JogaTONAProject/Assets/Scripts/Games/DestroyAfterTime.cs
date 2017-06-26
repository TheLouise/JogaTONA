using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {

	public float timeToDestruct;
	private float timeCounter;

	// Use this for initialization
	void Start () {
		timeCounter = 0;
	}

	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime;

		if (timeCounter >= timeToDestruct) {
			Destroy (gameObject);
		}
	}
}
