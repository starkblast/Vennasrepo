using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaitsmisScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D c) {
		Debug.Log (c.transform.name);
		--GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().elud;
	}
}
