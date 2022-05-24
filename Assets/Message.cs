using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{

	[SerializeField] Text message;
	[SerializeField] Text time;
    // Start is called before the first frame update
    void Start()
    {
        message.text = "Great job, " + PersistentData.Instance.GetName()+ "!";
	time.text = "Your time was: " + PersistentData.Instance.GetTimer().ToString("F0")+ " seconds";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
