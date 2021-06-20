using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenSlime : MonoBehaviour
{

    //movement speed of the slime (Unity input) 
    public float slimeMoveSpeed = 5.0f;

    //When player enters the trigger it kills them
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Dead");
            other.gameObject.GetComponent<Player>().isDead = true;
        }
    }
    
    void Update()
    { 
        //Makes the slime move to the left
        transform.position += -transform.forward* Time.deltaTime * slimeMoveSpeed;
    }
}
