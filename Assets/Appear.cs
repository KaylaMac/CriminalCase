using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    	bool isLabGun;
	bool isLabBullet;
	bool isLabBob;
	bool isLabLois;
	bool isLabKnife;
	bool isLabAmmo;
	bool isLabBullet2;
	bool areShells;

	[SerializeField] GameObject labGun;
	[SerializeField] GameObject labBullet;
	[SerializeField] GameObject labBullet2;
	[SerializeField] GameObject labBob;
	[SerializeField] GameObject labLois;
	[SerializeField] GameObject labKnife;
	[SerializeField] GameObject labAmmo;
	[SerializeField] GameObject labShells;

    // Start is called before the first frame update
    void Start(){
    	
	isLabGun = PersistentData.Instance.GetLabGun();
	labGun.SetActive(isLabGun);

	isLabBullet = PersistentData.Instance.GetLabBullet();
	labBullet.SetActive(isLabBullet);

	isLabBullet2 = PersistentData.Instance.GetLabBullet2();
	labBullet2.SetActive(isLabBullet2);

	isLabBob = PersistentData.Instance.GetLabCurly();
	labBob.SetActive(isLabBob);

	isLabLois = PersistentData.Instance.GetLabRed();
	labLois.SetActive(isLabLois);
	
	isLabKnife = PersistentData.Instance.GetLabKnife();
	labKnife.SetActive(isLabKnife);

	isLabAmmo = PersistentData.Instance.GetLabAmmo();
	labAmmo.SetActive(isLabAmmo);

	areShells = PersistentData.Instance.GetLabShells();
	labShells.SetActive(areShells);
    }
}
