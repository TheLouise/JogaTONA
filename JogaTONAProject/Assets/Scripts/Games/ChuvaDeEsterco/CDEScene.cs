using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CDEScene : SceneController {

	// Update is called once per frame
	public void Update () {
		base.Update ();

		if (timer <= 0) {
			vaca.ganhou = true;
		}

	}
}
