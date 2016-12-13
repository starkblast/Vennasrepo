using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NupukateScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
		if (transform.name == "m2ngi") {
			Application.LoadLevel ("main skene");
		} else if (transform.name == "6petus") {
			Application.LoadLevel("6petuse skene");
		} else if (transform.name == "sponsorid") {
			Application.LoadLevel("sponsorite skene");
		}
	}
}
