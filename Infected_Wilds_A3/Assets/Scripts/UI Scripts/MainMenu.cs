/*
Title: Make Your MAIN MENU Quickly! | Unity UI Tutorial For Beginners
Author: Rehope Games
Date: 08 May 2023
Code version: N/A
Availability: https://www.youtube.com/watch?v=DX7HyN7oJjE&list=PLmwQNimN3PLb5BtAm0u5M0qS3IOKpnmAC&index=4
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Cutscene()
    {  // This method is used to load the level for the first time. (When Play is pressed)
        SceneManager.LoadScene("Cutscene 1");
    }

    
    public void QuitGame ()
    {   //This method is used to exit the game's application. (When Quit button is pressed)
        Application.Quit();
    }
}
