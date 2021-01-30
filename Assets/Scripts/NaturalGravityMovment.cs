using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaturalGravityMovment : MonoBehaviour
{
    
    public float movmentSpeed;
    private Rigidbody rb;
    private Vector3 directionVector;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        addForce();
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            setCurrentVelocity(2);
            return;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            setCurrentVelocity(3);
            return;
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            setCurrentVelocity(0);
            return;
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            setCurrentVelocity(1);
            return;
        }
        
        
        
    }


    private void addForce()
    {
        
        rb.AddForce(directionVector*movmentSpeed);
        
    }


    private void setCurrentVelocity(int direction)
    {

        switch (direction)
        {
            case 0:
                directionVector = new Vector3(0,0,1);
                break;
            case 1:
                directionVector = new Vector3(0,0,-1);
                break;
            case 2:
                directionVector = new Vector3(1,0,0);
                break;
            case 3:
                directionVector = new Vector3(-1,0,0);
                break;
        }
        
        
    }

    public void setDirection(Vector3 newDirection)
    {
        directionVector = newDirection;
    }

    public void setVelocity(Vector3 newVelocity)
    {
        rb.velocity = newVelocity;
    }

    public Vector3 getDirection()
    {

        return directionVector;
    }

    public Vector3 getVelocity()
    {
        return rb.velocity;
    }
    
    
}
