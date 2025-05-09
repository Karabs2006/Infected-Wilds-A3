using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonTwo : MonoBehaviour
{

    public void PlayScene()
    {  // This method is used to load the second cutscene when the button is pressed
        SceneManager.LoadScene("Game Play");
    }
    
}
