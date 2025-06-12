using UnityEngine;

public class SimpleDoor : MonoBehaviour
{
    public bool isLocked = true;
    public KeyCode openKey = KeyCode.Space;
    public float openForce = 200f;

    private HingeJoint2D hinge;
    private Rigidbody2D rb;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        rb = GetComponent<Rigidbody2D>();

        // Lock the door at start
        if (isLocked)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    void Update()
    {
        // Check if player is nearby and pressing Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TryOpenDoor();
        }
    }

    void TryOpenDoor()
    {
        if (isLocked)
        {
            // Check if player has key
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player.GetComponent<PlayerInventory>().hasKey)
            {
                UnlockDoor();
                OpenDoor();
            }
            else
            {
                Debug.Log("Door is locked! Find a key.");
            }
        }
        else
        {
            OpenDoor();
        }
    }

    void UnlockDoor()
    {
        isLocked = false;
        rb.constraints = RigidbodyConstraints2D.None;
        Debug.Log("Door unlocked!");
    }

    void OpenDoor()
    {
        // Push door based on player position
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 playerPos = player.transform.position;

        // Determine push direction (left or right)
        float direction = (playerPos.x > transform.position.x) ? 1f : -1f;

        // Apply force to swing door
        rb.AddForce(new Vector2(direction * openForce, 0));
    }
}