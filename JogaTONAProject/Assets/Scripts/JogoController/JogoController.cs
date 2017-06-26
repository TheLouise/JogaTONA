using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class JogoController {

	public static List<string> minigames;
	public static List<string> cenasGanhadas;

	public static int  vidas;
	public static int  vitorias;
	public static int minigameIndex;
	public static bool ganhoufase;

	public static void Init () {
		minigames = new List<string> ();
		cenasGanhadas = new List<string> ();

		minigames.Add ("AtravessarARua");
		minigames.Add ("ChuvaDeEsterco");
		minigames.Add ("HungryHungryCow");
		minigames.Add ("Ordenhar");
		minigames.Add ("Salame");
		minigames.Add ("UdderInvaders");
		minigames.Add ("RunningCow");


		vidas = 9999999;
		vitorias = 0;
		ganhoufase = false;
	}

	public static void EscolherCena(){
		if (vidas >= 0) {
			minigameIndex = Random.Range (0, minigames.Count);
			Debug.Log (minigames [minigameIndex] + " : " + minigameIndex + " escolher " + minigames.Count);
			SceneManager.LoadScene (minigames [minigameIndex]);
		} else if (vidas < 0) {
			
			SceneManager.LoadScene (9);
		} else if (vitorias == 7) {
			SceneManager.LoadScene (8);
		}
	}

	public static void VerificaVitoria(){
		if (ganhoufase == true) {
			Debug.Log (minigames [minigameIndex] + " : "+ minigameIndex + " ganhar " +minigames.Count );
			cenasGanhadas.Add (minigames [minigameIndex]);
			minigames.RemoveAt (minigameIndex);
			vitorias++;
		} else {
			vidas--;
		}
		EscolherCena ();
	}
}
