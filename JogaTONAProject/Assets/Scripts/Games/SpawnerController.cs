using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

	public GameObject prefab;

	public Transform start;
	public Transform end;

	public float cooldown;
	protected float cooldownTimer;

	public bool infinito;
	public int limite;
	private int contador;

	// Use this for initialization
	void Start () {
		//transform.position = Vector3.zero;
		cooldownTimer = 0f;
	}
	
	// Update is called once per frame
	public void Update () {
		cooldownTimer += Time.deltaTime;

		if (infinito == true) {
			if (cooldownTimer >= cooldown) {
				Spawn ();
			}
		}

		if (infinito == false) {
			if (cooldownTimer >= cooldown && limite > contador) {
				Spawn ();
			}
		}
	}

	public void Spawn(){
		Vector3 position = new Vector3 ();

		position.x = Random.Range (start.position.x, end.position.x);
		position.y = Random.Range (start.position.y, end.position.y);
		position.z = Random.Range (start.position.z, end.position.z);

		Instantiate (prefab, position, Quaternion.identity);
		cooldownTimer = 0;

		if (infinito == false)
			contador++;
	}
}
