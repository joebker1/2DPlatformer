/*
Description: This script is the camera controller that centers on the players character and follows them around the level.
*/

using UnityEngine;
using System.Collections;


public class CameraContoller : MonoBehaviour
{
	public GameObject player;
	
	
	private Vector3 offset;
	
	
	void Start ()
	{
		offset = transform.position - player.transform.position;
	}
	
	
	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
	}
	
}
