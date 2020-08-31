using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCFazendeiro : MonoBehaviour {

	private Rigidbody2D body;
	private Vector2 point2Target;

	private float timeCounter = 0;

	public Rigidbody2D target;
	public bool morreu;
	public float speed;
	public float rotatingSpeed;
	public float timeToDestruct;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
		morreu = false;
	}
	
	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime;

		if (timeCounter >= timeToDestruct)
			DestroyFazendeiro ();
	}

	void FixedUpdate(){
		point2Target = (Vector2)transform.position - (Vector2)target.transform.position;
		point2Target.Normalize ();

		float value = Vector3.Cross (point2Target, transform.right).z;

		body.angularVelocity = rotatingSpeed * value;
		body.velocity = transform.right * speed;
	}

	void DestroyFazendeiro() {
        gameObject.SetActive(false);
	}
}
