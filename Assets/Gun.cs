using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
	GameObject FactsAboutIsoder; 
    bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetGun();
	this.gameObject.SetActive(isClicked);
	FactsAboutIsoder = GameObject.Find("FactsAboutIsoder");
	FactsAboutIsoder.SetActive(false);
    }

	private void OnMouseDown(){
		PersistentData.Instance.SetGunShown();
		PersistentData.Instance.SetLabGun();
		FactsAboutIsoder.SetActive(true); //Add
		this.gameObject.SetActive(false);
	}	
}
