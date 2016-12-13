using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signlanguage : MonoBehaviour {
    public bool lillanupp = false;
    public bool kollanenupp = false;
    public Sprite kollanetervitus;
    public Sprite lillatervitus;
    private Sprite praegune;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        praegune = spriteRenderer.sprite;

    }

    // Update is called once per frame
    void Update() {
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        if (lillanupp == false || kollanenupp == false)
        {
           // spriteRenderer.sprite = praegune;
        }
        if (lillanupp == true)
        {
			lillaAction();
          //  spriteRenderer.sprite = lillatervitus;
        }
        if (kollanenupp == true)
        {
			kollaneAction ();
           // spriteRenderer.sprite = kollanetervitus;
        }
	}

	void lillaAction() {
		spriteRenderer.sprite = lillatervitus;
		lillanupp = false;
		Invoke ("normaalne", 0.35f);
	}

	void kollaneAction(){
		kollanenupp = false;
		spriteRenderer.sprite = kollanetervitus;
		Invoke ("normaalne", 0.35f);
	}

	void normaalne () {
		spriteRenderer.sprite = praegune;
	}
}
