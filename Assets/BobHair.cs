using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobHair : MonoBehaviour
{

	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetBob();
	this.gameObject.SetActive(isClicked);
    }

    private void OnMouseDown(){
		PersistentData.Instance.SetBobHairShown();
		PersistentData.Instance.SetLabCurly();
		this.gameObject.SetActive(false);
	}
}
