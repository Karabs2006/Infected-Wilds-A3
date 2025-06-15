using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public PlayerShooting playerShooting;

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
            Destroy(gameObject);
        }

    }

    public void Next()
    {
        Time.timeScale = 1f;
        dialogue.SetActive(false);
       
       
    }
}
