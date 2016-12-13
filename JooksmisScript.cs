using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JooksmisScript : MonoBehaviour {
	public float speed;
	public Sprite lillavend;
	public Sprite kollanevend;
	private System.Random rnd = new System.Random();
	private int skoor;
	private int eelskoor;
	private bool upd8 = false;

	void Start () {
		speed = GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().speed;
		skoor = GameObject.Find ("objekt kus on erinev info").GetComponent<ElamisScript> ().skoor;
		int vend = rnd.Next(0, 2);
		if (vend == 0) {
			GetComponent<SpriteRenderer> ().sprite = lillavend;
		} else {
			GetComponent<SpriteRenderer> ().sprite = kollanevend;
		}
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
}
