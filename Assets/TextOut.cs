using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOut : MonoBehaviour
{

	[SerializeField] Text welcome;
	string playerName;

    // Start is called before the first frame update
    void Start()
    {
        playerName = PersistentData.Instance.GetName();
	welcome.text = "Welcome, Detective " + playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
