using UnityEngine;

public class Dialogue4 : MonoBehaviour
{

    public Collider2D collider2D;

    public GameObject dialogue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {
        Time.timeScale = 1f;
        dialogue.SetActive(false);
        Destroy(collider2D);
            
    }

}
