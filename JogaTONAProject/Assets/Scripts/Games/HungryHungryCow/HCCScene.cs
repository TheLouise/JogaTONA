using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HCCScene : SceneController {

	public HHCVaca Hvaca;

	// Update is called once per frame
	void Update () {
		base.Update ();

		if (timer <= 0 && Hvaca.comidas < 7)
			vaca.morta = true;
	}
}
