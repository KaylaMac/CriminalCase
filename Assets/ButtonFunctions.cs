using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{

	GameObject gunPanel;
	[SerializeField] InputField inputName;
    // Start is called before the first frame update
    void Start()
    {
    	gunPanel = GameObject.Find("GunPanel");
	gunPanel.SetActive(false);
	
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Main(){
		PersistentData.Instance.SetGunShown(true);
		PersistentData.Instance.SetLabGun(false);
		PersistentData.Instance.SetBulletShown(true);
		PersistentData.Instance.SetLabBullet(false);
		PersistentData.Instance.SetBullet2Shown(true);
		PersistentData.Instance.SetLabBullet2(false);
		PersistentData.Instance.SetBobHairShown(true);
		PersistentData.Instance.SetLabCurly(false);
		PersistentData.Instance.SetLoisHairShown(true);
		PersistentData.Instance.SetLabRed(false);
		PersistentData.Instance.SetKnifeShown(true);
		PersistentData.Instance.SetLabKnife(false);
		PersistentData.Instance.SetAmmoShown(true);
		PersistentData.Instance.SetLabAmmo(false);
		PersistentData.Instance.SetShellsShown(true);
		PersistentData.Instance.SetLabShells(false);
		PersistentData.Instance.SetFiredShown(true);
		PersistentData.Instance.SetFiredFound(false);
		SceneManager.LoadScene("MainMenu");
	}

	public void Briefing(){
		if(inputName.text != ""){
			string s = inputName.text;
			PersistentData.Instance.SetName(s);
			PersistentData.Instance.SetInstructions();
			PersistentData.Instance.ResetTimer();
			SceneManager.LoadScene("Briefing");
		}
	} 

	public void Living_Room(){
		SceneManager.LoadScene("Living");
	}

	public void Lois_Room(){
		SceneManager.LoadScene("LoisRoom");
	}

	public void Rileys_Room(){
		SceneManager.LoadScene("RileyRoom");
	}

	public void Bobs_Room(){
		SceneManager.LoadScene("BobRoom");
	}

	public void Suspect_Room(){
		SceneManager.LoadScene("SuspectLineup");
	}

	public void Lab(){
		SceneManager.LoadScene("Lab");
	}

	public void GSR(){
		SceneManager.LoadScene("GSRTest");
	}

	public void PrintsExamine(){
		SceneManager.LoadScene("FingerPrintExamination");
	}

	public void Close(){
		PersistentData.Instance.SetInstructions();
	}

	public void CloseBulletFacts(){
		GameObject bulletFacts = GameObject.Find("BulletFacts");
		bulletFacts.SetActive(false);
	}

	public void CloseHairFacts(){
		GameObject hairFacts = GameObject.Find("HairFacts");
		hairFacts.SetActive(false);
	}

	public void CloseGunFacts(){ 
		GameObject GSRFact = GameObject.Find("GSR");
		GSRFact.SetActive(false);
	}

	public void CloseKnifeFacts(){
		GameObject FactsAboutIsider = GameObject.Find("FactsAboutIsider");
		FactsAboutIsider.SetActive(false);
	}

	public void CloseAmmopackFacts(){ //AmmoPack
		GameObject AltasVampireFact = GameObject.Find("AltasVampireFact");
		AltasVampireFact.SetActive(false);
	}

	public void CloseB2Fact(){ //bullet2
		GameObject GhostSniperFact = GameObject.Find("GhostSniperFact");
		GhostSniperFact.SetActive(false);
	}

	public void CloseBShellFact(){
		GameObject FiringBulletUpFact = GameObject.Find("FiringBulletUpFact");
		FiringBulletUpFact.SetActive(false);
	}

	public void CloseBCarvings1(){
		GameObject ZodiacKillerFact = GameObject.Find("ZodiacKillerFact");
		ZodiacKillerFact.SetActive(false);
	}

	public void CloseBobHairItem(){
		GameObject DBCooperFact = GameObject.Find("DBCooperFact");
		DBCooperFact.SetActive(false);
	}

	public void CloseResults(){ 
		GameObject ResultsPanel= GameObject.Find("TestResults");
		ResultsPanel.SetActive(false);
	}

	public void CloseGunPanel(){
		gunPanel.SetActive(false);
	}


	public void OpenGunPanel(){
		gunPanel.SetActive(true); 
	}
	
}
