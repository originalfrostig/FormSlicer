using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPart : MonoBehaviour
{
    public GameObject player;

    public bool isAktiv;

    private void OnCollisionEnter(Collision other)
    {
        if (isAktiv)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                float yPos = player.transform.position.y;
                player.transform.position =  new Vector3(other.contacts[0].point.x,yPos,other.contacts[0].point.z);
                player.SetActive(true);
            
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            } 
        }
    }
}
