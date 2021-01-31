using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureSwitchScript : MonoBehaviour
{
    
    public GameObject wall;
    
    public Transform wallTop;
    public Transform wallBottom;

    private float speed = 1.5f;
    
    public bool isOn;
    public Material active;
    public Material inactive;
    private Material[] inactiveMaterials;
    private Material[] activeMaterials;
    private MeshRenderer renderer;


    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        this.activeMaterials = new[] {renderer.materials[0], active};
        this.inactiveMaterials = new[] {renderer.materials[0], inactive};
    }

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
            renderer.materials = activeMaterials;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isOn = false;  
            renderer.materials = inactiveMaterials;

        }
    }
}
