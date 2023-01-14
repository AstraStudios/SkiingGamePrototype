using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiMovement : MonoBehaviour
{
    int currentDirection;

    float vertSpeed = .5f;
    float horizSpeed = 2f;

    Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        currentDirection = 1;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
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
            rb2D.AddForce(new Vector2(-horizSpeed, -vertSpeed));
        }
        if (currentDirection == 3)
        {
            rb2D.AddForce(new Vector2(horizSpeed, -vertSpeed));
        }
    }
}
