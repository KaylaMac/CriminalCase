using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    	int playerScore;
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
	
	public static PersistentData Instance;


    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
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

	public void SetScore(int s){playerScore = s;}
	public int GetScore(){return playerScore;}

	public void SetName(string s){playerName = s;}
	public string GetName(){return playerName;}

	public void SetGunShown(){gunShown = false;}
	public bool GetGun(){return gunShown;}
	public void SetLabGun(){isGunInLab = true;}
	public bool GetLabGun(){return isGunInLab;}
	
	public void SetBulletShown(){bulletShown = false;}
	public bool GetBullet(){return bulletShown;}
	public void SetLabBullet(){isBulletInLab = true;}
	public bool GetLabBullet(){return isBulletInLab;}

	public void SetBullet2Shown(){bullet2Shown = false;}
	public bool GetBullet2(){return bullet2Shown;}
	public void SetLabBullet2(){isBullet2InLab = true;}
	public bool GetLabBullet2(){return isBullet2InLab;}

	public void SetBobHairShown(){bobHairShown = false;}
	public bool GetBob(){return bobHairShown;}
	public void SetLabCurly(){isCurlyInLab = true;}
	public bool GetLabCurly(){return isCurlyInLab;}

	public void SetLoisHairShown(){loisHairShown = false;}
	public bool GetLois(){return loisHairShown;}
	public void SetLabRed(){isRedInLab = true;}
	public bool GetLabRed(){return isRedInLab;}

	public void SetKnifeShown(){knifeShown = false;}
	public bool GetKnife(){return knifeShown;}
	public void SetLabKnife(){isKnifeInLab = true;}
	public bool GetLabKnife(){return isKnifeInLab;}

	public void SetAmmoShown(){ammoShown = false;}
	public bool GetAmmo(){return ammoShown;}
	public void SetLabAmmo(){isAmmoInLab = true;}
	public bool GetLabAmmo(){return isAmmoInLab;}

	public void SetShellsShown(){bulletShellsShown = false;}
	public bool GetShells(){return bulletShellsShown;}
	public void SetLabShells(){areShellsInLab = true;}
	public bool GetLabShells(){return areShellsInLab;}

	public void SetFiredShown(){firedShown = false;}
	public bool GetFired(){return firedShown;}
	public void SetFiredFound(){isFiredFound = true;}
	public bool GetFiredFound(){return isFiredFound;}

	public void SetInstructions(){instructionsPanel = !instructionsPanel;}
	public bool GetInstructions(){return instructionsPanel;}
}
