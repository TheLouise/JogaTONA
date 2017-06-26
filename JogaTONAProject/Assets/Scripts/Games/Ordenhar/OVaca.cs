using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVaca : VacaController {

	public GameObject leite;
	private bool spawnou = false;

	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown && spawnou == false) {
			Instantiate (leite, gameObject.transform.position, Quaternion.identity);
			spawnou = true;
		}
	}
}
