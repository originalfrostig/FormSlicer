using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitterScirpt : MonoBehaviour
{

    public GameObject[] playerParts;

    public GameObject canvas;

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            _audioSource.Play();
            
            canvas.SetActive(true);
            
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
