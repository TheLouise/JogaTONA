using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UINave : MonoBehaviour {

	private Rigidbody2D nave;

	public bool destruida;

	// Use this for initialization
	void Start () {
		nave = GetComponent<Rigidbody2D> ();
		destruida = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (destruida == true) {
			transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
			Invoke ("DestroyNave", 1);
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.CompareTag ("bala")) {
			destruida = true;
		}
	}

	void DestroyNave(){
		Destroy (gameObject);
	}
}
