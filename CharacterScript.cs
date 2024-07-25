/*
Description: This script basically the GameManager script. It controls the player and the Game Systems like the win and lose screen, respwans, life counter and game over.
I fix this problem in later scripts. This script allows the player to run, jump, and collect coins using the arrow keys and space bar. When the player loses
all three lives, the player will end the game, and if the player gets to the final checkpoint, the player will recieve the win screen.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterScript : MonoBehaviour
{
	SpriteRenderer sr;
	Rigidbody2D rb;
	float playerSpeed = 6f;
	float jumpForce = 9f;
	
	public Text countText;
	public Text winText;
	public Text loseText;
	private int count;

	public Vector3 respawnPoint;

	public int defaultLives;
	public int livesCounter;

	public Text livesText;

	public HeartSystem damage;

	public GameObject[] hearts;
	public int life;
	private bool dead;

	void Start()
    {
	    sr = GetComponent <SpriteRenderer>();
	    rb = GetComponent <Rigidbody2D>();
	    
	    count = 0;
	    winText.text = "";
	    SetCountText ();

		livesCounter = defaultLives;
	}

   
    void Update()
    {
	    float hPos = Input.GetAxis("Horizontal"); //horizontal movement
	    transform.Translate(hPos * playerSpeed * Time.deltaTime, 0, 0);
	    
	    if (hPos > 0)
	    {
		    sr.flipX = true;
	    }
	    
	    if (hPos < 0)
	    {
		    sr.flipX = false;
	    }
	    
	    playerJump();

		if (life < 1)
		{
			Destroy(hearts[0].gameObject);
		}
		else if (life < 2)
		{
			Destroy(hearts[1].gameObject);
		}
		else if (life < 3)
		{
			Destroy(hearts[2].gameObject);
		}

		if (life == 0)
        {
			loseText.text = "Game Over!";

			Time.timeScale = 0;
		}
	}
    
    void playerJump()
    {
	    if ( (Input.GetKeyDown(KeyCode.Space)) && (rb.velocity.y == 0) )
	    {
		    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
	    }
    
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
		Debug.Log("made it here");
		if (other.gameObject.CompareTag("PickUp"))
	    {
			other.gameObject.SetActive (false);
		    count = count + 100;
		    SetCountText ();

			AudioSource source = GetComponent<AudioSource>();
			source.Play();

		}

		if (other.gameObject.CompareTag("Chest"))
		{
			other.gameObject.SetActive(false);
			count = count + 500;
			SetCountText();

			AudioSource source = GetComponent<AudioSource>();
			source.Play();

		}

		if (other.gameObject.CompareTag("Danger"))
		{
			Debug.Log("Player Hit! " + other.gameObject.name);

			transform.position = respawnPoint;

			life--;
		}

		if (other.gameObject.CompareTag("Checkpoint"))
        {
			respawnPoint = other.transform.position;
        }
    }
    
    void SetCountText ()
    {
	    countText.text = "Count: " + count.ToString ();
	    if (count >= 2600)
	    {
			winText.text = "You Win!";

			Time.timeScale = 0;
		}

    }



}

