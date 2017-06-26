using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HHCVaca : VacaController {

	public SpriteRenderer choppspr;
	public GameObject chopp;
	public Sprite[] chopps = new Sprite[7];

	public int comidas = 0;
	private int anglo = 20;
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			vaca.transform.Rotate(new Vector3(0,0,anglo));
			comidas++;
			if(comidas < chopps.Length)
				choppspr.sprite = chopps [comidas];
			anglo *= -1;
		}

		if (comidas >= 7) {
			Destroy (chopp);
			ganhou = true;
		}
	}
}
