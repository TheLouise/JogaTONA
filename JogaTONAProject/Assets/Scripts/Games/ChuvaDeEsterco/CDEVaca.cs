using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDEVaca : VacaController {

	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");

		vaca.AddForce (new Vector2 (horizontal * force, 0));
		var pos = transform.position;

		if (pos.x < -6f)
			pos.x = 5.5f;
		if (pos.x > 5.7f)
			pos.x = -5.8f;
		
		transform.position = pos;
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.CompareTag("coco")) {
			morta = true;
		}
	}
}
