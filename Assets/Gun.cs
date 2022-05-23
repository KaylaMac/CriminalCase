using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
	GameObject GSRFacts; 
    bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetGun();
	this.gameObject.SetActive(isClicked);
	GSRFacts = GameObject.Find("GSR");
	GSRFacts.SetActive(false);
    }

	private void OnMouseDown(){
		PersistentData.Instance.SetGunShown();
		PersistentData.Instance.SetLabGun();
		GSRFacts.SetActive(true);
		this.gameObject.SetActive(false);
	}	
}
