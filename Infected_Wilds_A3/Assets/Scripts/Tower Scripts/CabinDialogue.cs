using UnityEngine;

public class CabinDialogue : MonoBehaviour
{
    public GameObject dialogue;

    public Collider2D dialogueCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogue.SetActive(false);
    }

    // Update is called once per frame
    
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
