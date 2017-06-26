using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AARVaca : VacaController {
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			vaca.AddForce (new Vector2 (0, -force));
		}

		if (morta == true) {
			transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Carro") {
			morta = true;
		}

		if (col.gameObject.name == "EndOfTheRoad") {
			ganhou = true;
		}
	}
}
