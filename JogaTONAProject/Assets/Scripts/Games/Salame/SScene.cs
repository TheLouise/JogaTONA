using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SScene : SceneController {
	
	// Update is called once per frame
	void Update () {
		base.Update ();

		if (timer <= 0)
			vaca.ganhou = true;
	}
}
