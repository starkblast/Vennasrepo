﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElamisScript : MonoBehaviour {
	public int elud;
	public float speed = 0.05f;
	public GameObject vend;
	public float vaheldus = 3f;
	public int skoor = 0;
	public Sprite kolm;
	public Sprite kaks;
	public Sprite yks;
	private SpriteRenderer elu1;
	private SpriteRenderer elu2;
	private SpriteRenderer elu3;
	private GUIStyle stail;
	private int eelskoor;
	private bool upd8;
	private bool upd8l;
	//public List<GameObject> jooksjad;

	// Use this for initialization
	void Start () {
		elu1 = transform.Find ("elu 1").GetComponent<SpriteRenderer> ();
		elu2 = transform.Find ("elu 2").GetComponent<SpriteRenderer> ();
		elu3 = transform.Find ("elu 3").GetComponent<SpriteRenderer> ();

		//transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite == kolm;
		Invoke ("loeAlla", 1f);
		//InvokeRepeating ("teeUusVend", 0f, vaheldus);
	}
	
	// Update is called once per frame
	void Update () {
		if (eelskoor != skoor) {
			upd8 = false;
			upd8l = false;
		}
		if (skoor % 3 == 0 && skoor > 1 && !upd8 && vaheldus >= 0.25) {
			vaheldus = vaheldus * 0.975f;
			upd8 = true;
		}
		if (skoor % 42 == 0 && skoor > 1 && !upd8l && elud < 3) {
			elud += 1;
			upd8l = true;
		}
		eelskoor = skoor;

		if (elud == 3) {
			elu1.color = Color.white;
			elu2.color = Color.white;
			elu3.color = Color.white;
		} else if (elud == 2) {
			elu1.color = Color.white;
			elu2.color = Color.white;
			elu3.color = Color.clear;
		} else if (elud == 1) {
			elu1.color = Color.white;
			elu2.color = Color.clear;
			elu3.color = Color.clear;
		} else if (elud <= 0) {
			elu1.color = Color.clear;
			if (PlayerPrefs.GetInt ("haiskoor") < skoor) {
				PlayerPrefs.SetInt ("haiskoor", skoor);
			}
			if (PlayerPrefs.HasKey("total")) {
				PlayerPrefs.SetInt ("total", PlayerPrefs.GetInt("total") + skoor);
			} else {
				PlayerPrefs.SetInt("total", skoor);
			}
			PlayerPrefs.SetInt ("skoor", skoor);
			Application.LoadLevel ("surma skene");
		}
	}

	void teeUusVend() {
		GameObject uusVend = Instantiate (vend, transform.position, transform.rotation);
		//jooksjad.Add(uusVend);
		Invoke("teeUusVend", vaheldus);

	}

	void loeAlla() {
		if (transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite == kolm) {
			transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite = kaks;
			Invoke ("loeAlla", 1f);
		} else if (transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite == kaks) {
			transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite = yks;
			Invoke ("loeAlla", 1f);
			Invoke("teeUusVend", vaheldus);
		} else if (transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite == yks) {
			transform.Find ("kaunter").GetComponent<SpriteRenderer> ().color = Color.clear;
		}
	}

	void OnGUI() {
		stail = new GUIStyle(GUI.skin.label);
		stail.normal.textColor = Color.black;
		stail.fontSize = 30;
		GUI.Label(new Rect(Screen.width/2-20, Screen.height-100, 400, 40), skoor.ToString(), stail);
	}
}
