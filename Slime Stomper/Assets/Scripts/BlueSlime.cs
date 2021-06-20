using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSlime : MonoBehaviour
{
    //checks if the slime is touching the ground
    private bool isGrounded = true;

    public float jumpHeight;

    //these are variables used to apply velocity and gravity to the slime later in code 
    Vector3 velocity = Vector3.zero;
    Vector3 gravity = new Vector3(0, 9.8f, 0);


    void Update()
    {
        //if the slime is under 0.5 on the y axis then it is grounded
        if (transform.position.y <= 0.5)
        {
            isGrounded = true;
        }

        //otherwise it's not grounded
        else
        {
            isGrounded = false;
        }

        //if the slime is grounded it's velocity is set to zero
        if (isGrounded == true)
        {
            velocity = new Vector3(0, jumpHeight, 0);
        }

        //Apply velocity to the players position (all the time) 
        transform.position += velocity * Time.deltaTime;

        //Apply gravity to players velocity
        velocity -= gravity * Time.deltaTime;
    }

    //When something enters the trigger
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Debug.Log("Player Dead");
            other.gameObject.GetComponent<Player>().isDead = true;
        }
    }
}
