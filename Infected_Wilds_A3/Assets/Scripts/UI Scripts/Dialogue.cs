using UnityEngine;

public class Dialogue : MonoBehaviour
{

    public GameObject dialogue;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
        dialogue.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {

            Time.timeScale = 1f;
            dialogue.SetActive(false);

    }


}
