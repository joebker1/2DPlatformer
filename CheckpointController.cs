/*
Description: This script updates whether or not the player has reached a checkpoint.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public bool checkpointReached;




    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            checkpointReached = true;
        }
    }




}
