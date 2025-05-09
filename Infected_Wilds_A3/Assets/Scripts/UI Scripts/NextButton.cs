using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{

    public void PlayScene()
    {  // This method is used to load the second cutscene when the button is pressed
        SceneManager.LoadScene("Cutscene 2");
    }
    
}
