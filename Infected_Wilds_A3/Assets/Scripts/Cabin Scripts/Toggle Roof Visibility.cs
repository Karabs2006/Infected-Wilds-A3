using UnityEngine;

public class ToggleRoofVisibility : MonoBehaviour
{
    [SerializeField] private GameObject roof; // Assign your roof in Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            roof.SetActive(false); // Hide roof when player enters
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            roof.SetActive(true); // Show roof when player exits
    }
}