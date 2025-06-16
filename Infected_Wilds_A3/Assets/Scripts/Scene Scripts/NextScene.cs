using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string nextSceneName = "NextScene"; // Name of the scene to load after time
    public float duration = 5f; // How long to wait before switching

    void Start()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene(nextSceneName);
    }
}
