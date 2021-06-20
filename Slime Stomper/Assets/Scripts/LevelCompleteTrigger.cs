using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteTrigger : MonoBehaviour
{
    public GameManager gameManager;

    //if the player collides with the object then bring up the level complete UI
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameManager.LevelComplete();
        }
    }
}