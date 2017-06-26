using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacaController : MonoBehaviour {

	protected Rigidbody2D vaca;

	public bool morta;
	public bool ganhou;

	public float force;

	// Use this for initialization
	public void Start () {
		vaca = GetComponent<Rigidbody2D> ();
		morta = false;
		ganhou = false;
	}
}
