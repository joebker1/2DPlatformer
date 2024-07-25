using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	public float leftBoundary, rightBoundary;
	
	public float speed;
	private float waitTime;
	public float startWaitTime;
	
	public Transform[] moveSpots;
	private int randomSpot;
	
	public bool moveRight = false;
	
	void Start()
	{
		waitTime = startWaitTime;
		randomSpot = Random.Range(0, moveSpots.Length);
		
		
	}
	
	void Update()
	{
		if (transform.position.x > rightBoundary)
			moveRight = false;
		if (transform.position.x < leftBoundary)
			moveRight = true;

		if (moveRight)
		{
			transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
			transform.eulerAngles = new Vector3 (0, 180, 0);
		}
		else {
			transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
			transform.eulerAngles = new Vector3 (0, 0, 0);
		}
		/*
		transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
		
		if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
		{
			if (waitTime <=0)
			{
				randomSpot = Random.Range(0, moveSpots.Length);
				
				waitTime = startWaitTime;
			}
			else {
				waitTime -= Time.deltaTime;
			}
		}
		*/
		
	}
	
	
	
}
