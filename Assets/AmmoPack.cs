using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPack : MonoBehaviour
{
	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetAmmo();
	this.gameObject.SetActive(isClicked);
    }

    private void OnMouseDown(){
		PersistentData.Instance.SetAmmoShown();
		PersistentData.Instance.SetLabAmmo();
		this.gameObject.SetActive(false);
    }
}
