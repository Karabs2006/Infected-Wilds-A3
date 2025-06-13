using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject roof;
    public GameObject floor;

    public void SetInside(bool isInside)
    {
        roof.SetActive(!isInside); // Hide roof when inside
        floor.SetActive(isInside); // Show floor when inside
    }
}