using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{
	
	bool isClicked;
	GameObject bulletFacts;
	GameObject bulletTwo;

    void Start(){
        isClicked = PersistentData.Instance.GetBullet();
	this.gameObject.SetActive(isClicked);
	bulletFacts = GameObject.Find("BulletFacts");
	bulletFacts.SetActive(false);
	bulletTwo = GameObject.Find("bullet1");
	bulletTwo.SetActive(isClicked);
    }
    
    void Update(){      
    }

	private void OnMouseDown(){
		PersistentData.Instance.SetBulletShown(false);
		PersistentData.Instance.SetLabBullet(true);
		this.gameObject.SetActive(false);
		bulletTwo.SetActive(false);
		bulletFacts.SetActive(true);
	}
}
