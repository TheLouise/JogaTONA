using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iniciar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		JogoController.Init ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			JogoController.EscolherCena ();
		}
	}
}
