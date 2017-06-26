using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OScene : SceneController {

	public AcertouOBalde balde;

	// Update is called once per frame
	public void Update () {
		base.Update ();

		if (balde.acertou == true)
			vaca.ganhou = true;

		if (timer <= 0)
			vaca.morta = true;
	}
}
