using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiredBullet : MonoBehaviour
{
    GameObject ZodiacKillerFact;
	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetFired();
	this.gameObject.SetActive(isClicked);
    ZodiacKillerFact = GameObject.Find("ZodiacKillerFact");
    ZodiacKillerFact.SetActive(false);
    }

   private void OnMouseDown(){
	PersistentData.Instance.SetFiredShown();
	PersistentData.Instance.SetFiredFound();
    ZodiacKillerFact.SetActive(true); 
	this.gameObject.SetActive(false);
   }
}
