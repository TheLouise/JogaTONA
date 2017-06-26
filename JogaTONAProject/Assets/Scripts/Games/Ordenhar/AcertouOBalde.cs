using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcertouOBalde : MonoBehaviour {

	public bool acertou;
	// Use this for initialization
	void Start () {
		acertou = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.CompareTag ("leite")) {
			acertou = true;
			transform.localScale += new Vector3 (2f, 2f, 2f);
		}
	}
}
