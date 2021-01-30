using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour
{

    public float strength = 100;
    
    

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Vector3 direction =  other.GetContact(0).normal - transform.position ;
            
            other.gameObject.GetComponent<Rigidbody>().AddForce(direction*strength,ForceMode.Impulse);
        }
    }
}
