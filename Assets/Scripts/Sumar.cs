using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sumar : MonoBehaviour {
	GameObject txt_toques;
	Contador ctrl_toques;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		txt_toques = GameObject.Find ("Toques");
		ctrl_toques = txt_toques.GetComponent<Contador> ();
	}
	
	// Update is called once per frame
	void OnMouseDown()
	{ctrl_toques.suma_toques (1);
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Suelo") {
			ctrl_toques.resetear();
		}
	}
}
