using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Personaje : MonoBehaviour {
    static public string nombre;
    static public bool isSphere;

    public Mesh sphere, cube;

    public Text nombreUI;
	// Use this for initialization
	void Start () {
        if (nombre == "") {
            nombre = "nombrePorDefecto";
        }
        GetComponent<MeshFilter>().mesh = isSphere ? sphere : cube;
        nombreUI.text = nombre;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
