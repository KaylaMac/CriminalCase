using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	bool isClicked;
	
	GameObject bulletFacts;
	GameObject bulletTwo;

    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetBullet();
	this.gameObject.SetActive(isClicked);
	bulletFacts = GameObject.Find("BulletFacts");
	bulletFacts.SetActive(false);
	bulletTwo = GameObject.Find("bullet1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnMouseDown(){
		PersistentData.Instance.SetBulletShown();
		PersistentData.Instance.SetLabBullet();
		this.gameObject.SetActive(false);
		bulletTwo.SetActive(false);
		bulletFacts.SetActive(true);
	}
}
