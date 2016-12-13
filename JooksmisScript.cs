using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JooksmisScript : MonoBehaviour {
	public float speed = 0.01f;
	public Sprite lillavend;
	public Sprite kollanevend;
	private System.Random rnd = new System.Random();

	void Start () {
		int vend = rnd.Next(0, 2);
		if (vend == 0) {
			GetComponent<SpriteRenderer> ().sprite = lillavend;
		} else {
			GetComponent<SpriteRenderer> ().sprite = kollanevend;
		}
	}
	

	void Update () {
		transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
	}
}
