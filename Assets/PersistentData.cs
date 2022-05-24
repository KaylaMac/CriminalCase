using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
	string playerName;

	bool gunShown;
	bool isGunInLab;
	bool bulletShown;
	bool isBulletInLab;
	bool bobHairShown;
	bool isCurlyInLab;
	bool loisHairShown;
	bool isRedInLab;
	bool knifeShown;
	bool isKnifeInLab;
	bool ammoShown;
	bool isAmmoInLab;
	bool bullet2Shown;
	bool isBullet2InLab;
	bool bulletShellsShown;
	bool areShellsInLab;
	bool firedShown;
	bool isFiredFound;

	bool instructionsPanel;

	float timer;
	
	public static PersistentData Instance;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
	playerName = "";
	gunShown = true;
	isGunInLab = false;
	bulletShown = true;
	isBulletInLab = false;
	bobHairShown = true;
	isCurlyInLab = false;
	loisHairShown = true;
	isRedInLab = false;
	knifeShown = true;
	isKnifeInLab = false;
	ammoShown = true;
	isAmmoInLab = false;
	bullet2Shown = true;
	isBullet2InLab = false;
	bulletShellsShown = true;
	areShellsInLab = false;
	firedShown = true;
	isFiredFound = false;

	instructionsPanel = false;
    }

	private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        } 
    }

	void Update()
    {
		timer+= Time.deltaTime;
	}

	public float GetTimer(){return timer;}
	public void ResetTimer(){timer = 0;}

	public void SetName(string s){playerName = s;}
	public string GetName(){return playerName;}

	public void SetGunShown(bool boolean){gunShown = boolean;}
	public bool GetGun(){return gunShown;}
	public void SetLabGun(bool boolean){isGunInLab = boolean;}
	public bool GetLabGun(){return isGunInLab;}
	
	public void SetBulletShown(bool boolean){bulletShown = boolean;}
	public bool GetBullet(){return bulletShown;}
	public void SetLabBullet(bool boolean){isBulletInLab = boolean;}
	public bool GetLabBullet(){return isBulletInLab;}

	public void SetBullet2Shown(bool boolean){bullet2Shown = boolean;}
	public bool GetBullet2(){return bullet2Shown;}
	public void SetLabBullet2(bool boolean){isBullet2InLab = boolean;}
	public bool GetLabBullet2(){return isBullet2InLab;}

	public void SetBobHairShown(bool boolean){bobHairShown = boolean;}
	public bool GetBob(){return bobHairShown;}
	public void SetLabCurly(bool boolean){isCurlyInLab = boolean;}
	public bool GetLabCurly(){return isCurlyInLab;}

	public void SetLoisHairShown(bool boolean){loisHairShown = boolean;}
	public bool GetLois(){return loisHairShown;}
	public void SetLabRed(bool boolean){isRedInLab = boolean;}
	public bool GetLabRed(){return isRedInLab;}

	public void SetKnifeShown(bool boolean){knifeShown = boolean;}
	public bool GetKnife(){return knifeShown;}
	public void SetLabKnife(bool boolean){isKnifeInLab = boolean;}
	public bool GetLabKnife(){return isKnifeInLab;}

	public void SetAmmoShown(bool boolean){ammoShown = boolean;}
	public bool GetAmmo(){return ammoShown;}
	public void SetLabAmmo(bool boolean){isAmmoInLab = boolean;}
	public bool GetLabAmmo(){return isAmmoInLab;}

	public void SetShellsShown(bool boolean){bulletShellsShown = boolean;}
	public bool GetShells(){return bulletShellsShown;}
	public void SetLabShells(bool boolean){areShellsInLab = boolean;}
	public bool GetLabShells(){return areShellsInLab;}

	public void SetFiredShown(bool boolean){firedShown = boolean;}
	public bool GetFired(){return firedShown;}
	public void SetFiredFound(bool boolean){isFiredFound = boolean;}
	public bool GetFiredFound(){return isFiredFound;}

	public void SetInstructions(){instructionsPanel = !instructionsPanel;}
	public bool GetInstructions(){return instructionsPanel;}
}
