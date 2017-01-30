using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Contador : MonoBehaviour {
	public int toques = 0;
	Text texto;

	void Start(){
		texto = GetComponent<Text> ();
		resetear (); 
	}

	public void suma_toques (int cantidad){
		toques = toques + cantidad; //monedas += cantidad;
		if (toques < 0) {
			toques = 0;
		}
		texto.text = toques.ToString ();
	}

	public void resetear (){
		toques = 0;
		texto.text = toques.ToString ();
	}
}