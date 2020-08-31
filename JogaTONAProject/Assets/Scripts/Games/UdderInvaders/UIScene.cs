using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScene : SceneController {

	public int score;

	// Update is called once per frame
	void Update () {
		base.Update ();

		if (score == 3)
			vaca.ganhou = true;

		if (timer <= 0)
			vaca.morta = true;

	}
}
