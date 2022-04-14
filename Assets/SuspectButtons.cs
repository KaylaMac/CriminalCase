using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspectButtons : MonoBehaviour
{

	bool isShown;
	bool isShown1;
	bool isShown2;
	
	GameObject bobScroll;
	GameObject loisScroll;
	GameObject rilScroll;
    // Start is called before the first frame update
    void Start()
    {
        bobScroll = GameObject.Find("BobScroll");
	loisScroll = GameObject.Find("LoisScroll");
	rilScroll = GameObject.Find("RileyScroll");

	isShown = false;
	isShown1 = false;
	isShown2 = false;

	bobScroll.SetActive(false);
	loisScroll.SetActive(false);
	rilScroll.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Bob(){
		isShown = !isShown;
		bobScroll.SetActive(isShown);
	}

	public void Lois(){
		isShown1 = !isShown1;
		loisScroll.SetActive(isShown1);
	}

	public void Riley(){
		isShown2 = !isShown2;
		rilScroll.SetActive(isShown2);
	}
}
