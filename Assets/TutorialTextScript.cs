using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTextScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int tutorial = PlayerPrefs.GetInt("Tutorial", 0);
        if (tutorial == 0)
        {
            
        }
        else
        {
            gameObject.SetActive(false);
            
        }
        
        PlayerPrefs.SetInt("Tutorial",1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            gameObject.SetActive(false);
        }
    }
}
