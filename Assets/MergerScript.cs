using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergerScript : MonoBehaviour
{
    public int amountParts;
    public GameObject player;

    public List<GameObject> parts;

    public Transform pos;

    // Update is called once per frame
    void Update()
    {
        if (parts.Count >= amountParts)
        {
            foreach (GameObject part in parts)
            {
                part.SetActive(false);
            }
            
            
            player.transform.position = pos.position;
            player.SetActive(true);

            this.enabled = false;

        }
        
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            parts.Add(other.gameObject); 
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            parts.Remove(other.gameObject);
        }
    }
}
