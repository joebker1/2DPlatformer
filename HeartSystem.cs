/*
Description: This script controls the heart sprites, removing hearts when the player takes damage from a hazard, controlled in the CharacterScript.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;
    private bool dead;

    private void Start()
    {
        life = hearts.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            //dead code
            Debug.Log("You are dead!");
        }
    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            life -= d;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                dead = true;
            }
        }
    }


}
