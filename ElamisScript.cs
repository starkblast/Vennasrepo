using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElamisScript : MonoBehaviour {
	public int elud;
	public GameObject vend;
	public float vaheldus = 1f;
	//public List<GameObject> jooksjad;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("teeUusVend", 0f, vaheldus);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void teeUusVend() {
		GameObject uusVend = Instantiate (vend, transform.position, transform.rotation);
		//jooksjad.Add(uusVend);
	}
}
