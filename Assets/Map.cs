using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

	GameObject[] mapShown;
    	GameObject mapHidden;
    // Start is called before the first frame update
    void Start()
    {
        mapShown = GameObject.FindGameObjectsWithTag("showMap");
	mapHidden = GameObject.Find("MapButton");

	foreach(GameObject g in mapShown)
		g.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ShowMap(){
		mapHidden.SetActive(false);
		foreach(GameObject g in mapShown)
			g.SetActive(true);
	}

	public void HideMap(){
		mapHidden.SetActive(true);
		foreach(GameObject g in mapShown)
			g.SetActive(false);
	}
}
