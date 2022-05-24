using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScores : MonoBehaviour
{

	GameObject highScores;
    // Start is called before the first frame update
    void Start()
    {
        highScores = GameObject.Find("HighScoresPanel");
	highScores.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void DisplayScores(){
		highScores.SetActive(true);
	}
}
