using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0f,0f,1f) * speed * Time.deltaTime);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Target")) {
            Destroy(other.gameObject);
        }
    }
}
