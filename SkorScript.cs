﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkorScript : MonoBehaviour {
	private GUIStyle stail;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		stail = new GUIStyle(GUI.skin.label);
		stail.normal.textColor = Color.magenta;
		stail.fontSize = 20;
		GUI.Label(new Rect(Screen.width/2-60, Screen.height/2+10, 400, 40),"haiskoor: "+ PlayerPrefs.GetInt("haiskoor").ToString(), stail);
		if (PlayerPrefs.HasKey("total")) {
			GUI.Label(new Rect(Screen.width/2-60, Screen.height/2+33, 400, 40), "koguskoor: " + PlayerPrefs.GetInt("total").ToString(), stail);
		}
	}
}
