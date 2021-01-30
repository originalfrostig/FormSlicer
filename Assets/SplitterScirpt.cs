using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitterScirpt : MonoBehaviour
{

    public GameObject[] playerParts;
    
    

    private void OnCollisionEnter(Collision other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            Vector3 currentVelocity = other.gameObject.GetComponent<NaturalGravityMovment>().getVelocity();
            Vector3 direction = other.gameObject.GetComponent<NaturalGravityMovment>().getDirection();
            
            other.gameObject.SetActive(false);
            
            foreach (GameObject part in playerParts)
            {
                part.SetActive(true);
                part.GetComponent<NaturalGravityMovment>().setVelocity(currentVelocity);
                part.GetComponent<NaturalGravityMovment>().setDirection(direction);
            }

            
            GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
