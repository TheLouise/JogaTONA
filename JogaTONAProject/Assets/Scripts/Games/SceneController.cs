using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {

	public Text timerTxt;
	public GameObject nextTela;

	public GameObject ganhou;
	public GameObject perdeu;

	protected float timer;
	public bool isRunning;

	private float oldTimer;

	public VacaController vaca;
	private bool bloquear;

	// Use this for initialization
	void Start () {
		timer = 5;
		oldTimer = timer;

		isRunning = true;
		Time.timeScale = 1;

		nextTela.SetActive (false);
		ganhou.SetActive (false);
		perdeu.SetActive (false);

		bloquear = false;
	}

	// Update is called once per frame
	public void Update () {
		timer -= Time.deltaTime;
		if (timer >= 0) {
			timerTxt.text = Mathf.RoundToInt (timer).ToString ();
		}

		if (!bloquear) {
			

			if (vaca.morta == true) {
				StartCoroutine ("EndGame");
			}

			if (vaca.ganhou == true) {
				StartCoroutine (Ganhou());

			}
		}
	}

	IEnumerator EndGame(){
		print ("perdeu");
		bloquear = true;
		Time.timeScale = 0;
		oldTimer += Time.unscaledDeltaTime;
		nextTela.SetActive (true);
		perdeu.SetActive (true);
		yield return new WaitForSecondsRealtime (1f);
		JogoController.ganhoufase = false;
		JogoController.VerificaVitoria ();
	}

	IEnumerator Ganhou(){
		print ("ganhou");
		bloquear = true;
		Time.timeScale = 0;
		oldTimer += Time.unscaledDeltaTime;
		nextTela.SetActive (true);
		ganhou.SetActive (true);
		yield return new WaitForSecondsRealtime (1f);
		JogoController.ganhoufase = true;
		JogoController.VerificaVitoria ();
	}
}