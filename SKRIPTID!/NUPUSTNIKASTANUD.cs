using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NUPUSTNIKASTANUD : MonoBehaviour {
    public bool kollanenupp = false;
    public bool lillanupp = false;
	public Sprite lillavend;
	public Sprite kollanevend;
	private GameObject mees;
	private GameObject mull;
	public GameObject kullikas;
	public GameObject lullikas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
    {
		mees = GameObject.Find ("need kes jooksevad 1(Clone)");
		SpriteRenderer koll = mees.GetComponent<SpriteRenderer> ();
        if (this.name == "KOLLANENUPP") {	
			if (koll.sprite == kollanevend) {
				++GameObject.Find("objekt kus on erinev info").GetComponent<ElamisScript>().skoor;
			} else if (koll.sprite == lillavend) {
				--GameObject.Find("objekt kus on erinev info").GetComponent<ElamisScript>().elud;
				mees.GetComponent<JooksmisScript> ().speed = 0;
				mull = Instantiate (lullikas, new Vector3 (mees.transform.position.x - 0.30f, mees.transform.position.y + 0.80f, transform.position.z), transform.rotation);
			}
			Invoke ("sure", 1f);
            GameObject.Find("see kes kaitseb").GetComponent<signlanguage>().kollanenupp = true;
        }
		else if (this.name == "LILLANUPP")
		{	
			if (koll.sprite == lillavend) {
				++GameObject.Find("objekt kus on erinev info").GetComponent<ElamisScript>().skoor;
			} else if (koll.sprite == kollanevend) {
				--GameObject.Find("objekt kus on erinev info").GetComponent<ElamisScript>().elud;
				mees.GetComponent<JooksmisScript> ().speed = 0;
				mull = Instantiate (kullikas, new Vector3 (mees.transform.position.x - 0.30f, mees.transform.position.y + 0.80f, transform.position.z), transform.rotation);

			}
			Invoke ("sure", 1f);
            GameObject.Find("see kes kaitseb").GetComponent<signlanguage>().lillanupp = true;
        }
    }
    void OnMouseUp()
    {
        kollanenupp = false;
        lillanupp = false;
    }

	void sure() {
		Destroy (mees);
		Destroy (mull);
	}
}
