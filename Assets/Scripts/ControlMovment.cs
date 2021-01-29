using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovment : MonoBehaviour
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
        
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            setCurrentVelocity(2);
            return;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            setCurrentVelocity(3);
            return;
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            setCurrentVelocity(0);
            return;
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            setCurrentVelocity(1);
            return;
        }
        
        rb.velocity = Vector3.zero;
        
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
