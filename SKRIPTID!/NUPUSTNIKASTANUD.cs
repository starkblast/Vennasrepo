using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NUPUSTNIKASTANUD : MonoBehaviour {
    public bool kollanenupp = false;
    public bool lillanupp = false;
	public Sprite lillavend;
	public Sprite kollanevend;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
    {
		GameObject mees = GameObject.Find ("need kes jooksevad 1(Clone)");
		SpriteRenderer koll = mees.GetComponent<SpriteRenderer> ();
        if (this.name == "KOLLANENUPP") {	
			if (koll.sprite == kollanevend) {
				++GameObject.Find("objekt kus on erinev info").GetComponent<ElamisScript>().skoor;
			} else if (koll.sprite == lillavend) {
				--GameObject.Find("objekt kus on erinev info").GetComponent<ElamisScript>().elud;
			}
			Destroy(mees);
            GameObject.Find("see kes kaitseb").GetComponent<signlanguage>().kollanenupp = true;
        }
		else if (this.name == "LILLANUPP")
		{	
			if (koll.sprite == lillavend) {
				++GameObject.Find("objekt kus on erinev info").GetComponent<ElamisScript>().skoor;
			} else if (koll.sprite == kollanevend) {
				--GameObject.Find("objekt kus on erinev info").GetComponent<ElamisScript>().elud;
			}
			Destroy(mees);
            GameObject.Find("see kes kaitseb").GetComponent<signlanguage>().lillanupp = true;
        }
    }
    void OnMouseUp()
    {
        kollanenupp = false;
        lillanupp = false;
    }
}
