using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTwo : MonoBehaviour
{   
    GameObject GhostSniperFact;
	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetBullet2();
	this.gameObject.SetActive(isClicked);
    GhostSniperFact = GameObject.Find("GhostSniperFact");
	GhostSniperFact.SetActive(false);
    }

    private void OnMouseDown(){
	PersistentData.Instance.SetBullet2Shown();
	PersistentData.Instance.SetLabBullet2();
    GhostSniperFact.SetActive(true); //GhostSniperFact
	this.gameObject.SetActive(false);
    }
}
