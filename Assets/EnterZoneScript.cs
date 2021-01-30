using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterZoneScript : MonoBehaviour
{
   public BoxCollider wallCollider;


   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         wallCollider.enabled = true;
         other.gameObject.GetComponent<PlayerPart>().isAktiv = true;
      }
   }
}
