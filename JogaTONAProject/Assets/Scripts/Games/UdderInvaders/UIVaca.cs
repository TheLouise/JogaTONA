using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIVaca : VacaController {

	private Vector2 amplitude = new Vector2 (250, 0);

	private float cooldown = 0.2f;
	private float cooldownTimer = 0f;
	private float timeToDestruct = 3f;

	public GameObject bullet;
	public Transform spawn;
	public float fator;

	// Update is called once per frame
	void Update () {
		cooldownTimer += Time.deltaTime;
		timeToDestruct += Time.deltaTime;

		if (Input.anyKeyDown && cooldownTimer >= cooldown) {
			GameObject tiro = Instantiate (bullet, spawn.position, Quaternion.identity);
			cooldownTimer = 0;
		}
	}

	void FixedUpdate(){
		float y = Mathf.Sin (Time.time * fator) * Time.fixedDeltaTime * amplitude.x;
		vaca.position = new Vector2 (vaca.position.x, y);
	}
}
