using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //these are variables used to apply velocity and gravity to player later in code 
    Vector3 velocity = Vector3.zero;
    Vector3 gravity = new Vector3(0, 9.8f, 0);

    //variable used to later to see if a player is dead
    [HideInInspector]
    public bool isDead;

    public bool bounce;

    //creating variables that control the speed the player moves and how high they can jump based on Unity input
    public float playerMoveSpeed = 5.0f;
    public float jumpHeight;

    //checks if the player is touching the ground
    private bool isGrounded = true;


    void Start()
    {
        isDead = false;
        bounce = false;
    }

    void Update()
    {
        //if the player is under 0.5 on the y axis then the player is grounded
        if (transform.position.y <= 0.5)
        {
            isGrounded = true;
        }
        //otherwise they are not grounded
        else
        {
            isGrounded = false;
        }

        //If the player is below 0.5 on the y axis it sets the player 7 value to 0.5 to stop it from clipping into the ground
        if (transform.position.y < 0.5) 
        { 
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z); 
        }


        //Makes the player move forward  
        transform.position += transform.right * Time.deltaTime * playerMoveSpeed;

        //if the player is grounded their velocity is set to zero
        if(isGrounded == true)
        {
            velocity = Vector3.zero;

            //if space is pressed the player's velocity will change making them jump 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity = new Vector3(0, jumpHeight, 0);
            }
        }

        //Apply velocity to the players position (all the time) 
        transform.position += velocity * Time.deltaTime;

        //Apply gravity to players velocity
        velocity -= gravity * Time.deltaTime;

        //if the player dies then the level restarts
        if (isDead == true)
        {
            SceneManager.LoadScene("Level_1");
        }

        //makes the player bounce (increases y value of velocity by 1) 
        if (bounce == true)
        {
            velocity = new Vector3(0, jumpHeight +1 , 0);
        }
    }
}
