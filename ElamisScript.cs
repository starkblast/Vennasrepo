using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElamisScript : MonoBehaviour {
	public int elud;
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
		
		if (elud == 3) {
			elu1.color = Color.black;
			elu2.color = Color.black;
			elu3.color = Color.black;
		} else if (elud == 2) {
			elu1.color = Color.black;
			elu2.color = Color.black;
			elu3.color = Color.clear;
		} else if (elud == 1) {
			elu1.color = Color.black;
			elu2.color = Color.clear;
			elu3.color = Color.clear;
		} else if (elud <= 0) {
			elu1.color = Color.clear;
			if (PlayerPrefs.GetInt ("haiskoor") < skoor) {
				PlayerPrefs.SetInt ("haiskoor", skoor);
			}
			Application.LoadLevel ("surma skene");
		}
	}

	void teeUusVend() {
		GameObject uusVend = Instantiate (vend, transform.position, transform.rotation);
		//jooksjad.Add(uusVend);
	}

	void loeAlla() {
		if (transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite == kolm) {
			transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite = kaks;
			Invoke ("loeAlla", 1f);
		} else if (transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite == kaks) {
			transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite = yks;
			Invoke ("loeAlla", 1f);
			InvokeRepeating ("teeUusVend", 1f, vaheldus);
		} else if (transform.Find ("kaunter").GetComponent<SpriteRenderer> ().sprite == yks) {
			transform.Find ("kaunter").GetComponent<SpriteRenderer> ().color = Color.clear;
		}
	}

	void OnGUI() {
		stail = new GUIStyle(GUI.skin.label);
		stail.normal.textColor = Color.black;
		stail.fontSize = 30;
		GUI.Label(new Rect(Screen.width/2-20, Screen.height-100, 40, 40), skoor.ToString(), stail);
	}
}
