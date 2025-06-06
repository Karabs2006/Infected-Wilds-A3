using UnityEngine;

public class Tower : MonoBehaviour
{

    public Sprite newTower;
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D trigger)
    {   // This code is used to used to increase the Player's Health once they collide with the Health Kit

        Player playerScript = trigger.gameObject.GetComponent<Player>();

        if (trigger.gameObject.name == "Player")
        {
            spriteRenderer.sprite = newTower;
            

        }
    }
}