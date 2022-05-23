using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwabBehavior : MonoBehaviour
{

	private Vector3 dragOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnMouseDown(){
		dragOffset = transform.position - GetMousePos();
	}

	void OnMouseDrag(){
		transform.position = GetMousePos() + dragOffset;
	}

	Vector3 GetMousePos(){
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		return mousePos;
	}
}
