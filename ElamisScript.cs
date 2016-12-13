using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElamisScript : MonoBehaviour {
	public int elud;
	public GameObject vend;
	public float vaheldus = 1f;
	public int skoor = 0;
	public Sprite kolm;
	public Sprite kaks;
	public Sprite yks;
	//public List<GameObject> jooksjad;

	// Use this for initialization
	void Start () {
		Invoke ("loeAlla", 1f);
		//InvokeRepeating ("teeUusVend", 0f, vaheldus);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void teeUusVend() {
		GameObject uusVend = Instantiate (vend, transform.position, transform.rotation);
		//jooksjad.Add(uusVend);
	}

	void loeAlla() {
		if (GetComponent<SpriteRenderer> ().sprite == kolm) {
			GetComponent<SpriteRenderer> ().sprite = kaks;
			Invoke ("loeAlla", 1f);
		} else if (GetComponent<SpriteRenderer> ().sprite == kaks) {
			GetComponent<SpriteRenderer> ().sprite = yks;
			InvokeRepeating ("teeUusVend", 1f, vaheldus);
		}
	}
}
