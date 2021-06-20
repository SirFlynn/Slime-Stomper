using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    //When player enters the trigger it kills them
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Dead");
            other.gameObject.GetComponent<Player>().isDead = true;
        }
    }
}
