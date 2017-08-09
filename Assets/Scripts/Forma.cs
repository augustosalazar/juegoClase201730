using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Forma : MonoBehaviour {
    public bool isSphere;
    public Sprite sphere, cube;
    public Image imageComponent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeVisual() {
        isSphere = !isSphere;
        imageComponent.sprite = isSphere ? sphere : cube;
    }
}
