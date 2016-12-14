using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class KaitsmisScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().jooksjad.ElementAt(0).transform.name);
		//Destroy (GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().jooksjad.ElementAt(i));
	}

	void OnCollisionEnter2D (Collision2D c) {
		//Debug.Log (c.transform.name);
		if (c.transform.name == "need kes jooksevad 1(Clone)") {
			--GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().elud;
			Debug.Log (c.transform.name);
		}
		//Destroy (GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().jooksjad [0]);
		//Destroy(c.gameObject);
	}

	/*void h2vitaVend() {
		Destroy(GameObject.Find("need kes jooksevad 1(Clone)"));
	}*/
}
