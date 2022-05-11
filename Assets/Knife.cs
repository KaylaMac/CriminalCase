using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetKnife();
	this.gameObject.SetActive(isClicked);
    }

    private void OnMouseDown(){
	PersistentData.Instance.SetKnifeShown();
	PersistentData.Instance.SetLabKnife();
	this.gameObject.SetActive(false);
    }
}
