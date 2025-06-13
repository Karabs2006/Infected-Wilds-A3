using UnityEngine;

public class Tower : MonoBehaviour
{

    public Sprite newTower;
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    public GameObject dialogue;

    public Collider2D destroyedTower;

    public Collider2D campCollider;

    public GameObject Wolf;

    public GameObject dialogue2;

    public GameObject dialogue3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        dialogue.SetActive(false);
        dialogue2.SetActive(false);
        dialogue3.SetActive(false);
        destroyedTower.enabled = false;
        Wolf.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Wolf == null)
        {
            Time.timeScale = 0f;
            dialogue3.SetActive(true);

        }


    }

    void OnTriggerEnter2D(Collider2D trigger)
    {   // This code is used to used to increase the Player's Health once they collide with the Health Kit

        Player playerScript = trigger.gameObject.GetComponent<Player>();


        if (trigger.gameObject.name == "Player")
        {
            spriteRenderer.sprite = newTower;
            destroyedTower.enabled = true;
            Time.timeScale = 0f;
            dialogue.SetActive(true);

        }
    }

    public void SpawnWolf()
    {
        Time.timeScale = 0f;
        dialogue.SetActive(false);
        Wolf.SetActive(true);
        dialogue2.SetActive(true);
    }

    public void Next()
    {
        Time.timeScale = 1f;
        dialogue2.SetActive(false);
        Destroy(campCollider);
    }

    public void end()
    {
        Time.timeScale = 1f;
        dialogue3.SetActive(false);

    }
}