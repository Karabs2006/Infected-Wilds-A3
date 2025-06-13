using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Give key to player
            other.GetComponent<PlayerInventory>().hasKey = true;
            Debug.Log("Key collected!");

            // Remove key from scene
            Destroy(gameObject);
        }
    }
}