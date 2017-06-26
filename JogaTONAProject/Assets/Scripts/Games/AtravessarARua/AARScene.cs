using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AARScene : SceneController {

	// Update is called once per frame
	void Update () {
		base.Update ();

		if (timer <= 0)
			vaca.morta = true;
			
	}
}
