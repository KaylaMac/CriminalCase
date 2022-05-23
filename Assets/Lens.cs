using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lens : MonoBehaviour
{
    [SerializeField]
    private Transform smallScratch, largeScratch;
    
    void Update()
    {
        largeScratch.position = smallScratch.position * 2 - transform.position;
    }

}
