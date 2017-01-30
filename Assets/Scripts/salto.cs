 using UnityEngine;
using System.Collections;

public class salto : MonoBehaviour {
    Vector3 gameMousePosition;
    Vector3 editorMousePosition;
	Vector3 vectorfuerza;
    public float fuerza = 100f;

    // Use this for initialization
    void OnMouseDown()
    {
        Debug.Log("Pulsado");
        // GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerza);
		gameMousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);

		editorMousePosition =
			Camera.main.ScreenToWorldPoint(gameMousePosition);

		vectorfuerza =  transform.position - editorMousePosition;

		if (vectorfuerza.y > 0) {
			GetComponent<Rigidbody2D> ().AddForceAtPosition (vectorfuerza * fuerza, new Vector2 (editorMousePosition.x, editorMousePosition.y));
		}

		if (vectorfuerza.y < 0) {
			GetComponent<Rigidbody2D> ().AddForceAtPosition (vectorfuerza * fuerza * (-1), new Vector2 (editorMousePosition.x * (-1), editorMousePosition.y));
		}
    }

}
