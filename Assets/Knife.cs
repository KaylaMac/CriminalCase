using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    GameObject FactsAboutIsider;
    GameObject RashawnBrazellFact;
	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetKnife();
	this.gameObject.SetActive(isClicked);
    FactsAboutIsider = GameObject.Find("FactsAboutIsider");
	FactsAboutIsider.SetActive(false);
    RashawnBrazellFact = GameObject.Find("RashawnBrazellFact");
    RashawnBrazellFact.SetActive(false);
    }

    private void OnMouseDown(){
	PersistentData.Instance.SetKnifeShown();
	PersistentData.Instance.SetLabKnife();
    FactsAboutIsider.SetActive(true);
    RashawnBrazellFact.SetActive(true);
	this.gameObject.SetActive(false);
    }
}
