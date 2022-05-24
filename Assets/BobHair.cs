using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobHair : MonoBehaviour
{
    GameObject DBCooperFact;
	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetBob();
	this.gameObject.SetActive(isClicked);
    DBCooperFact = GameObject.Find("DBCooperFact");
    DBCooperFact.SetActive(false);
    }

    private void OnMouseDown(){
		PersistentData.Instance.SetBobHairShown(false);
		PersistentData.Instance.SetLabCurly(true);
        DBCooperFact.SetActive(true);
		this.gameObject.SetActive(false);
	}
}
