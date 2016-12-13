using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NUPUSTNIKASTANUD : MonoBehaviour {
    public bool kollanenupp = false;
    public bool lillanupp = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        if (this.name == "KOLLANENUPP")
        {
            GameObject.Find("see kes kaitseb").GetComponent<signlanguage>().kollanenupp = true;
        }
        if (this.name == "LILLANUPP")
        {
            GameObject.Find("see kes kaitseb").GetComponent<signlanguage>().lillanupp = true;
        }
    }
    void OnMouseUp()
    {
        kollanenupp = false;
        lillanupp = false;
    }
}
