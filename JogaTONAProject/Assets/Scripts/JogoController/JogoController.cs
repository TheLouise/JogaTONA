using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class JogoController {

	public static List<string> minigames;
	public static List<string> cenasGanhadas;
    public static List<Sprite> milkshakes;
    public static List<Sprite> shakesColetados;

	public static int  vidas;
	public static int  vitorias;
	public static int minigameIndex;
	public static bool ganhoufase;

	public static void Init () {
		minigames = new List<string> ();
		cenasGanhadas = new List<string> ();
        milkshakes = new List<Sprite>();
        shakesColetados = new List<Sprite>();

		minigames.Add ("AtravessarARua");
		minigames.Add ("ChuvaDeEsterco");
		minigames.Add ("HungryHungryCow");
		minigames.Add ("Ordenhar");
		minigames.Add ("Salame");
		minigames.Add ("UdderInvaders");
		minigames.Add ("RunningCow");

        milkshakes.Add(Resources.Load<Sprite>("Sprites/Milks/milkblue"));
        milkshakes.Add(Resources.Load<Sprite>("Sprites/Milks/milklime"));
        milkshakes.Add(Resources.Load<Sprite>("Sprites/Milks/milkmagenta"));
        milkshakes.Add(Resources.Load<Sprite>("Sprites/Milks/milkorange"));
        milkshakes.Add(Resources.Load<Sprite>("Sprites/Milks/milkpurple"));
        milkshakes.Add(Resources.Load<Sprite>("Sprites/Milks/milkred"));
        milkshakes.Add(Resources.Load<Sprite>("Sprites/Milks/milkyellow"));

        vidas = 9999999;
		vitorias = 0;
		ganhoufase = false;
	}

	public static void EscolherCena(){
		if (vidas >= 0 && vitorias != 7) {
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
            shakesColetados.Add(milkshakes[minigameIndex]);
			minigames.RemoveAt (minigameIndex);
            milkshakes.RemoveAt(minigameIndex);
			vitorias++;
		} else {
			vidas--;
		}
		EscolherCena();
	}

    public static Sprite GetMilkshake()
    {
        Debug.Log("Returning " + milkshakes[minigameIndex].name);
        return milkshakes[minigameIndex];

    }
}
