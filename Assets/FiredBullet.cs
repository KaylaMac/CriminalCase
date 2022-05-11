using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiredBullet : MonoBehaviour
{

	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetFired();
	this.gameObject.SetActive(isClicked);
    }

   private void OnMouseDown(){
	PersistentData.Instance.SetFiredShown();
	PersistentData.Instance.SetFiredFound();
	this.gameObject.SetActive(false);
   }
}
