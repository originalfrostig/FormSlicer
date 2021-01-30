using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureSwitchScript : MonoBehaviour
{
    
    public GameObject wall;
    
    public Transform wallTop;
    public Transform wallBottom;

    private float speed = 1f;
    
    public bool isOn;




    // Update is called once per frame
    void Update()
    {
        if (isOn  )
        {
            if (wall.transform.position.y > wallBottom.transform.position.y)
            {
                modifyWall(speed *Time.deltaTime);
            }
            
           
        }

        if (!isOn && wall.transform.position.y < wallTop.transform.position.y)
        {
            modifyWall(-speed *Time.deltaTime);
        }
        
        
        
    }


    private void modifyWall(float mod)
    {
        wall.transform.position = new Vector3(wall.transform.position.x,wall.transform.position.y - mod,wall.transform.position.z);
      
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isOn = true;  
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isOn = false;  
        }
    }
}
