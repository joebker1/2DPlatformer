/*
Description: This script rotates the coins to entice the player.
*/

using UnityEngine;
using System.Collections;


public class Rotater : MonoBehaviour
{
	
    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
    }
    

    
}
