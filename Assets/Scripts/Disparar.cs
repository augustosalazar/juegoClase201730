using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour {
    public GameObject balaPrefab;

    public float offSet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            GameObject go = (GameObject)Instantiate(balaPrefab,transform.position + (transform.forward * offSet), transform.rotation);
            //go.transform.position = transform.position + transform.forward;
            //go.transform.LookAt(transform.forward);
        }
	}
}
