using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetGun();
	this.gameObject.SetActive(isClicked);
    }

	private void OnMouseDown(){
		PersistentData.Instance.SetGunShown();
		PersistentData.Instance.SetLabGun();
		this.gameObject.SetActive(false);
	}
}
