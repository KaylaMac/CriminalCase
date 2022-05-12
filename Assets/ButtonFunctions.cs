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

	public void Briefing(){
		if(inputName.text != ""){
			string s = inputName.text;
			PersistentData.Instance.SetName(s);
			PersistentData.Instance.SetInstructions();
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

	public void OpenGunPanel(){
		gunPanel.SetActive(true); 
	}
	
	
	public void CloseGun(){ //FactsAboutIsoder
		GameObject FactsAboutIsoder = GameObject.Find("FactsAboutIsoder");
		FactsAboutIsoder.SetActive(false);
	}
	

	public void PrintsExamine(){
		SceneManager.LoadScene("FingerPrintExamination");
	}
}
