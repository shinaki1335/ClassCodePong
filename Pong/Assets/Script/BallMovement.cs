using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    //variable for speed
    public float xSpeed = 0; //variable for horizontal speed
    public float ySpeed = 0; //variable for vertical speed

    //variable for borders
    private float xBorder = 7.5f; //variable for horizontal border
    private float yBorder = 4.5f; //variable for vertical border
    

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f;   //declare value for horizontal speed
        ySpeed = 0.0125f;   //declare value for vertical speed
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal movement
        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); //move right

        if (transform.position.x >= xBorder)
        {
            xSpeed = -xSpeed; //make it go left
        }

        if(transform.position.x <= -xBorder)
        { 
            xSpeed *= -1;
        }

        //vertical movement
        transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //move up 
        if (transform.position.y >= yBorder)
        { 
            ySpeed *= -1;
        }

        if (transform.position.y <= -yBorder) 
        {
           ySpeed *= -1;
        }

    }
}
