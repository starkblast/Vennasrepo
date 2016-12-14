using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signlanguage : MonoBehaviour {
    public bool lillanupp = false;
    public bool kollanenupp = false;
    public Sprite kollanetervitus;
    public Sprite lillatervitus;
	public Sprite kollanetervitus2;
	public Sprite lillatervitus2;
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
		Invoke ("Action2", 0.15f);
	}

	void kollaneAction(){
		kollanenupp = false;
		spriteRenderer.sprite = kollanetervitus;
		Invoke ("Action2", 0.25f);
	}

	void Action2() {
		if (spriteRenderer.sprite == kollanetervitus) {
			spriteRenderer.sprite = kollanetervitus2;
		} else {
			spriteRenderer.sprite = lillatervitus2;
		}
		Invoke ("normaalne", 0.25f);
	}

	void normaalne () {
		spriteRenderer.sprite = praegune;
	}
}
