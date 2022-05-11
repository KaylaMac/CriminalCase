using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
	GameObject instructions;
	bool isShown;
	
    // Start is called before the first frame update
    void Start()
    {
	isShown = PersistentData.Instance.GetInstructions();
        instructions = GameObject.Find("InstructionsPanel");
	instructions.SetActive(isShown);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
