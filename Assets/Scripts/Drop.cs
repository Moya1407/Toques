using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {
    Vector3 gameMousePosition;
    Vector3 editorMousePosition;
    public float fuerza = 100f;

    // Use this for initialization
    void OnMouseEnter() {
        Debug.Log("Entrando");
    }
    void OnMouseExit(){
        Debug.Log("Saliendo");
    }
    void OnMouseDown(){
        Debug.Log("Pulsado");
    }
    void OnMouseUp(){
        Debug.Log("Fin pulsado");
    }
    void OnMouseDrag(){
        Debug.Log("Arrastrando");
        gameMousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);

        editorMousePosition =
            Camera.main.ScreenToWorldPoint(gameMousePosition);

        transform.position = new Vector3
            (editorMousePosition.x,
            editorMousePosition.y,
            transform.position.z);
    }
}
