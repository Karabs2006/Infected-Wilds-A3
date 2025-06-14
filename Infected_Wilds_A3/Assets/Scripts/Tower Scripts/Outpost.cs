using UnityEngine;

public class Outpost : MonoBehaviour
{
    public GameObject dialogue2;
    public GameObject dialogue3;

    public Collider2D outpostCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogue2.SetActive(false);
        dialogue3.SetActive(false);

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
            dialogue2.SetActive(true);
        }

    }

    public void Next()
    {
       
        Time.timeScale = 0f;
        dialogue2.SetActive(false);
        dialogue3.SetActive(true);
      
    }

    public void Dialogue3()
    {

        Time.timeScale = 1f;
        dialogue3.SetActive(false);
        Destroy(outpostCollider);
       
  

    }
}
