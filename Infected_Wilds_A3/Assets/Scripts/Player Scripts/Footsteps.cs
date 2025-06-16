using UnityEngine;

public class WASDFootsteps : MonoBehaviour
{
    [Header("Audio Settings")]
    [SerializeField] private AudioClip[] footstepClips;
    [SerializeField] private float stepDelay = 0.4f; // Time between steps
    private AudioSource audioSource;
    private float stepCooldown;
    private bool wasMoving;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        bool isMoving =
        Input.GetKey(KeyCode.W) ||
        Input.GetKey(KeyCode.A) ||
        Input.GetKey(KeyCode.S) ||
        Input.GetKey(KeyCode.D);

        if (isMoving)
        {
            stepCooldown -= Time.deltaTime;

            if (stepCooldown <= 0)
            {
                PlayRandomFootstep();
                stepCooldown = stepDelay;
            }
        }
        else if (wasMoving)
        {
            // Optional: Play stop sound when movement ends
            stepCooldown = 0;
        }

        wasMoving = isMoving;
    }

    void PlayRandomFootstep()
    {
        if (footstepClips.Length == 0) return;

        AudioClip clip = footstepClips[Random.Range(0, footstepClips.Length)];
        audioSource.pitch = Random.Range(0.9f, 1.1f); // Slight pitch variation
        audioSource.PlayOneShot(clip);
    }
}