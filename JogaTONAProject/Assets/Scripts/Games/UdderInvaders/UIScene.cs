using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScene : SceneController {

	public UINave nave;

	public int score;

	/* não tá funcionando essa parte do score, eu acho que no UINave na parte que ele pega o Colison com a bala
	 * não tá dando tempo de contabilizar no Update lá, mas não dá pra contabilizar lá no UINave porque ele se destroi
	 * dai dá referência nula, WHAT THE HELL AAAAAAAAAAH */

	// Update is called once per frame
	void Update () {
		base.Update ();

		if (nave.destruida == true) {
			score++;
			Debug.Log("Score: " + score);
		}

		if (score == 3)
			vaca.ganhou = true;

		if (timer <= 0)
			vaca.morta = true;

	}
}
