using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShells : MonoBehaviour
{
	bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = PersistentData.Instance.GetShells();
	this.gameObject.SetActive(isClicked);
    }

    private void OnMouseDown(){
	PersistentData.Instance.SetShellsShown();
	PersistentData.Instance.SetLabShells();
	this.gameObject.SetActive(false);
    }
}
