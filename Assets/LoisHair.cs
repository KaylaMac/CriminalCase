using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoisHair : MonoBehaviour
{

	bool isClicked;
	GameObject hairFacts;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetLois();
	this.gameObject.SetActive(isClicked);
	hairFacts = GameObject.Find("HairFacts");
	hairFacts.SetActive(false);
    }

    private void OnMouseDown(){
	PersistentData.Instance.SetLoisHairShown(false); 	PersistentData.Instance.SetLabRed(true);
	hairFacts.SetActive(true);
	this.gameObject.SetActive(false);
    }
}
