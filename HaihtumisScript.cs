using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaihtumisScript : MonoBehaviour {
	private bool tagasi = false;
	// Use this for initialization
	private Color o;
	void Start () {
		o = GetComponent<SpriteRenderer> ().color;
		if (transform.name == "esitluspilt") {
			o = new Color (o.r, o.g, o.b, 0.01f);
		} else {
			o = new Color (o.r, o.g, o.b, 1f);
		}

		GetComponent<SpriteRenderer> ().color = o;
	}
	
	// Update is called once per frame
	void Update () {
		if (o.a >= 1) {
			tagasi = true;
		}
		if (o.a <= 0) {
			if (transform.name == "esitluspilt") {
				Application.LoadLevel ("title skene");
			}
		} else if (!tagasi) {
			o = new Color(o.r, o.g, o.b, o.a+0.01f);
			GetComponent<SpriteRenderer> ().color = o;
		} else {
			o = new Color(o.r, o.g, o.b, o.a-0.01f);
			GetComponent<SpriteRenderer> ().color = o;

		}
	}
}
