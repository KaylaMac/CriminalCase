using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    GameObject FactsAboutIsider;
	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetKnife();
	this.gameObject.SetActive(isClicked);
    FactsAboutIsider = GameObject.Find("FactsAboutIsider");
	FactsAboutIsider.SetActive(false);
    }

    private void OnMouseDown(){
	PersistentData.Instance.SetKnifeShown(false);
	PersistentData.Instance.SetLabKnife(true);
    FactsAboutIsider.SetActive(true);
	this.gameObject.SetActive(false);
    }
}
