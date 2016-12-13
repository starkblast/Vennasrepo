using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JooksmisScript : MonoBehaviour {
	public float speed = 0.02f;
	void Start () {
		
	}
	

	void Update () {
		transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
	}
}
