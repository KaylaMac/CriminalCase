using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShells : MonoBehaviour
{   
    GameObject FiringBulletUpFact; 
	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetShells();
	this.gameObject.SetActive(isClicked);
    FiringBulletUpFact = GameObject.Find("FiringBulletUpFact");
    FiringBulletUpFact.SetActive(false);
    }

    private void OnMouseDown(){
	PersistentData.Instance.SetShellsShown(false);
	PersistentData.Instance.SetLabShells(true);
    FiringBulletUpFact.SetActive(true); //FiringBulletUpFact
	this.gameObject.SetActive(false);
    }
}
