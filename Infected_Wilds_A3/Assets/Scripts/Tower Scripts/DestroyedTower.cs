using UnityEngine;

public class DestroyedTower : MonoBehaviour
{

    public GameObject dialogue;

    public Collider2D towerCollider;

    public bool isDestroyed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogue.SetActive(false);
        isDestroyed = false;

    }

    // Update is called once per frame
    void Update()
    {
      
        if (isDestroyed)
        {
            towerCollider.enabled = true;
            print("Tower is destroyed");

        }

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
        Destroy(towerCollider);
    }
}
