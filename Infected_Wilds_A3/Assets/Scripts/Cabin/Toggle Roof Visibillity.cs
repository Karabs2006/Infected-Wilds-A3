using UnityEngine;
using UnityEngine.UI;

public class ToggleRoofVisibility : MonoBehaviour
{
    [SerializeField] private GameObject roof; // Assign your roof in Inspector

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ToggleRoof);
    }

    private void ToggleRoof()
    {
        roof.SetActive(!roof.activeSelf); // Toggles roof visibility
    }
}
