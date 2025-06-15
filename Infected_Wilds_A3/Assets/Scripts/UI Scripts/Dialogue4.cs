using UnityEngine;

public class Dialogue4 : MonoBehaviour
{

    public Collider2D dialogueCollider;

    public GameObject dialogue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

 void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            dialogue.SetActive(true);
        }

    }


    public void Next()
    {
        Time.timeScale = 1f;
        dialogue.SetActive(false);
        Destroy(dialogueCollider);
    

    }
    
   

}
