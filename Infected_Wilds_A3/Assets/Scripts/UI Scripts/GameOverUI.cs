/*
Title: Make Your MAIN MENU Quickly! | Unity UI Tutorial For Beginners
Author: Rehope Games
Date: 08 May 2023
Code version: N/A
Availability: https://www.youtube.com/watch?v=DX7HyN7oJjE&list=PLmwQNimN3PLb5BtAm0u5M0qS3IOKpnmAC&index=4
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    
    public void RestartGame()
    {   // This method is used to reload the level once the Player has lost all their Health. (When Restart button is pressed)
        Time.timeScale = 1f; // Unfreeze time
        SceneManager.LoadScene("Game Play");
    }


    
    public void QuitGame()
    {//This method is used to exit the game's application. (When Quit button is pressed)
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}