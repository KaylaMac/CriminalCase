using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

	float opacity;
	GameObject reagent;
	GameObject results;
	SpriteRenderer render;
    // Start is called before the first frame update
    void Start()
    {
	results = GameObject.Find("TestResults");
	results.SetActive(false);
        reagent = GameObject.Find("Reagent");
	render = reagent.GetComponent<SpriteRenderer>();
	opacity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnCollisionEnter2D(Collision2D other)
    {

		if(other.gameObject.tag == "LoisSample"){
			InvokeRepeating("ChangeOpacity", 0f, 0.08f);
			StartCoroutine(WaitAndShowResults());
		}
	}

	void ChangeOpacity(){
		if(opacity < 1){
			opacity+=0.1f;
		}
		render.color = new Color(0.9f,0.5f,0.1f,opacity);
	}

	IEnumerator WaitAndShowResults(){
		yield return new WaitForSeconds(0.8f);
		results.SetActive(true);
	}
}
