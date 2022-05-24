using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class drop : MonoBehaviour
{

	Dropdown dropd;
	int value;
    // Start is called before the first frame update
    void Start()
    {
     	dropd = GetComponent<Dropdown>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Check(){
		value = dropd.value;
		if(value == 3)
			SceneManager.LoadScene("FinalScene");
	}
}
