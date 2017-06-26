using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCVaca : VacaController {

	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		vaca.velocity = new Vector2 (horizontal * force, vertical * force);
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.CompareTag ("fazendeiro"))
			morta = true;
	}
}
