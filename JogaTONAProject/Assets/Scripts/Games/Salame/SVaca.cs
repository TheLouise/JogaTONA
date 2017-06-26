using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SVaca : VacaController {

	private bool canJump = false;
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown && canJump == true) {
			vaca.AddForce (new Vector2 (0, force));
		}

		if (morta == true) {
			vaca.AddForce(new Vector2(0, 5000));
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.CompareTag ("salame")) {
			morta = true;
		}

		if (col.gameObject.CompareTag ("chao"))
			canJump = true;
	}

	void OnCollisionExit2D(Collision2D other){
		if (other.gameObject.CompareTag ("chao"))
			canJump = false;
	}
}
