using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityMovment : MonoBehaviour
{
    public float movmentSpeed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
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


    private void setCurrentVelocity(int direction)
    {

        switch (direction)
        {
           case 0:
               rb.velocity = new Vector3(0,0,movmentSpeed);
               break;
           case 1:
               rb.velocity = new Vector3(0,0,-movmentSpeed);
               break;
           case 2:
               rb.velocity = new Vector3(movmentSpeed,0,0);
               break;
           case 3:
               rb.velocity = new Vector3(-movmentSpeed,0,0);
               break;
        }
        
        
    }
    
    
}
