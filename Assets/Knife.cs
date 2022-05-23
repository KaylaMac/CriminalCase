using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    GameObject FactsAboutIsoder;
	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetKnife();
	this.gameObject.SetActive(isClicked);
    FactsAboutIsoder = GameObject.Find("FactsAboutIsoder");
	FactsAboutIsoder.SetActive(false);
    }

    private void OnMouseDown(){
	PersistentData.Instance.SetKnifeShown();
	PersistentData.Instance.SetLabKnife();
    FactsAboutIsoder.SetActive(true);
	this.gameObject.SetActive(false);
    }
}
