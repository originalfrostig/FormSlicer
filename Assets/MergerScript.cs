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

    private LevelControllerScript _levelControllerScript;

    public GameObject canvas;

    private AudioSource _audioSource;
    
    private void Start()
    {
        _levelControllerScript = FindObjectOfType<LevelControllerScript>();
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (parts.Count >= amountParts)
        {
            
            _audioSource.Play();
            
            canvas.SetActive(true);
            
            foreach (GameObject part in parts)
            {
                part.SetActive(false);
            }
            
            
            player.transform.position = pos.position;
            player.SetActive(true);

            _levelControllerScript.winGame();
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
