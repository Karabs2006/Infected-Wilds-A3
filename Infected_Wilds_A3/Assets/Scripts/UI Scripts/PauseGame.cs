using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }

    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        

    }

   public void QuitGame ()
    {   //This method is used to exit the game's application. (When Quit button is pressed)
       
        Application.Quit();
    }
    
}
