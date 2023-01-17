using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiMovement : MonoBehaviour
{
    // Basic explanation:
    // Current direction just gets a number based off of button pressed so you dont have to hold down buttons
    // Just adds force to the different sides, so turning feels a little muggy but thats ok.
    int currentDirection;

    float vertSpeed;
    float horizSpeed;

    Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        currentDirection = 1;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        //Keep low for development
        vertSpeed = 1f * Time.deltaTime;
        horizSpeed = 4f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        GetDirection();
        MovePlayer();
    }

    void GetDirection()
    {
        //Straight
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentDirection = 1;
        }
        //Turn left
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentDirection = 2;
        }
        //Turn right
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentDirection = 3;
        }
    }

    void MovePlayer()
    {
        if (currentDirection == 1)
        {
            rb2D.AddForce(new Vector2(0, -vertSpeed));
        }
        if (currentDirection == 2)
        {
            // If needed to revert,instead of 0 put -vertSpeed
            rb2D.AddForce(new Vector2(-horizSpeed, -vertSpeed));
        }
        if (currentDirection == 3)
        {
            rb2D.AddForce(new Vector2(horizSpeed, -vertSpeed));
        }
    }
}
