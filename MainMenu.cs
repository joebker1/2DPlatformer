/*
Description: This script controls the Main Menu, allowing the player to choose to play the game, or quit the game.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Area1");
        Debug.Log("Play Button Hit");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }




}
