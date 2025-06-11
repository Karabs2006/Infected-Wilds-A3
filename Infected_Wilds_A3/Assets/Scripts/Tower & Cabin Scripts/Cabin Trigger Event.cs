using UnityEngine;
using UnityEngine.Events;

public class Trigger2DEvents : MonoBehaviour
{
    [Header("2D Trigger Events")]
    public UnityEvent onTriggerEnter2D;
    public UnityEvent onTriggerExit2D;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            onTriggerEnter2D.Invoke();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            onTriggerExit2D.Invoke();
    }
}
