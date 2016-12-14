using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JooksmisScript : MonoBehaviour {
	public float speed;
	public Sprite lillavend;
	public Sprite kollanevend;
	public Sprite lillavend2;
	public Sprite kollanevend2;
	public Sprite lillavend3;
	public Sprite kollanevend3;
	public Sprite lillavend4;
	public Sprite kollanevend4;
	private System.Random rnd = new System.Random();
	private int skoor;
	private int eelskoor;
	private bool upd8 = false;
	public string man;

	void Start () {
		speed = GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().speed;
		skoor = GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().skoor;
		int vend = rnd.Next(0, 2);
		if (vend == 0) {
			GetComponent<SpriteRenderer> ().sprite = lillavend;
			man = "lilla";
		} else {
			GetComponent<SpriteRenderer> ().sprite = kollanevend;
			man = "kollane";
		}
		InvokeRepeating ("animatsioon", 0f, 0.09f);
	}


	void Update () {
		if (eelskoor != skoor) {
			upd8 = false;
		}
		if (skoor % 3 == 0 && skoor > 1 && !upd8) {
			
			GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().speed += 0.003f;
			speed = GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().speed;
			upd8 = true;
		}
		eelskoor = skoor;
		transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
	}

	void animatsioon(){
		if (GetComponent<SpriteRenderer> ().sprite == lillavend) {
			GetComponent<SpriteRenderer> ().sprite = lillavend2;
		} else if (GetComponent<SpriteRenderer> ().sprite == kollanevend) {
			GetComponent<SpriteRenderer> ().sprite = kollanevend2;
		} else if (GetComponent<SpriteRenderer> ().sprite == lillavend2) {
			GetComponent<SpriteRenderer> ().sprite = lillavend3;
		} else if (GetComponent<SpriteRenderer> ().sprite == kollanevend2) {
			GetComponent<SpriteRenderer> ().sprite = kollanevend3;
		} else if (GetComponent<SpriteRenderer> ().sprite == lillavend3) {
			GetComponent<SpriteRenderer> ().sprite = lillavend4;
		} else if (GetComponent<SpriteRenderer> ().sprite == kollanevend3) {
			GetComponent<SpriteRenderer> ().sprite = kollanevend4;
		} else if (GetComponent<SpriteRenderer> ().sprite == lillavend4) {
			GetComponent<SpriteRenderer> ().sprite = lillavend;
		} else if (GetComponent<SpriteRenderer> ().sprite == kollanevend4) {
			GetComponent<SpriteRenderer> ().sprite = kollanevend;
		}
	}
}
