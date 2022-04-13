using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Play(){
		SceneManager.LoadScene("Briefing");
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
}
