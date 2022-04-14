using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextInput : MonoBehaviour
{

	public string playerName;
	public InputField input;
    	public static TextInput instance;

    // Start is called before the first frame update
    void Start()
    {
        playerName = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

	public void SetName()
    {
        	playerName = input.text;
		SceneManager.LoadScene("Briefing");
    }

	public string GetName()
    {
        return playerName;
    }
}
