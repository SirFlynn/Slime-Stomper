using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //creating variables that control the speed the player moves and how heigh they can jump based on the user's input in Unity
    public float moveSpeed = 5.0f;
    public float jumpHeight;

    //creates a variable to help check if the player is touching the ground
    private bool isOnGround;

    //creating variables to help with calculation later
    [Space]
    public Rigidbody rb;
    //public Transform groundChecker;
    //public LayerMask ground;
    //Vector3 movement;


    void Start()
    {
        //The player is on the ground
        isOnGround = true;

        //Gets the Rigidbody component from the gameObject and stores it in the variable 'rb'
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Makes the player move forward  
        rb.AddForce(new Vector3(moveSpeed, 0, 0));

        //If Space is pressed and the player is touching the ground they will Jump
        if ((isOnGround == true) && (Input.GetKeyDown(KeyCode.Space)))
        {
            rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
        }
    }
}
