using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaturalGravityMovment : MonoBehaviour
{
    public float movmentSpeed;
    private Rigidbody rb;
    private Vector3 directionVector;


    private Vector2 initialPosition;

    private int direction;


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
        getSwipe();
        getInput();
    }

    private void getSwipe()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                initialPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                Vector2 swipeDirection = touch.position - initialPosition;

                swipeToMovment(swipeDirection);
            }
        }
    }

    private void swipeToMovment(Vector2 swipeDirection)
    {
        float xMovment = swipeDirection.x;
        float yMovment = swipeDirection.y;

        //  xMovment = xMovment / Math.Abs(xMovment);
        //   yMovment = yMovment / Math.Abs(yMovment);

        //   directionVector = new Vector3(xMovment,0,yMovment);

        if (xMovment > 0 && yMovment > 0)
        {
            setCurrentVelocity(2);
        }

        if (xMovment < 0 && yMovment < 0)
        {
            setCurrentVelocity(3);
        }

        if (xMovment < 0 && yMovment > 0)
        {
            setCurrentVelocity(0);
        }

        if (xMovment > 0 && yMovment < 0)
        {
            setCurrentVelocity(1);
        }

        /*    if (Math.Abs(xMovment) > Math.Abs(yMovment))
             {
                 if (xMovment > 0)
                 {
                     setCurrentVelocity(2);
                 }
                 else
                 {
                     setCurrentVelocity(3);
                 }
             }
             else
             {
                 if (yMovment > 0)
                 {
                     setCurrentVelocity(0);
                 }
                 else
                 {
                     setCurrentVelocity(1);
                 }
             } */
    }

    private void getInput()
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
        rb.AddForce(directionVector * movmentSpeed);
    }


    private void setCurrentVelocity(int direction)
    {
        if (direction != this.direction)
        {
            // direction changed
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        switch (direction)
        {
            case 0:
                directionVector = new Vector3(0, 0, 1);
                break;
            case 1:
                directionVector = new Vector3(0, 0, -1);
                break;
            case 2:
                directionVector = new Vector3(1, 0, 0);
                break;
            case 3:
                directionVector = new Vector3(-1, 0, 0);
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