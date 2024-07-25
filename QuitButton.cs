/*
Description: This script connects to the quit button, allowing the player to quit the game when pressing the button.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
	public void quitButton ()
	{
		Application.Quit();

		Debug.Log("Quit Game");
	}
	
}
