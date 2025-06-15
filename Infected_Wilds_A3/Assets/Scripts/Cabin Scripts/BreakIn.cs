using UnityEngine;

public class BreakIn : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject dialogue2;

    public GameObject dialogue3;
    public GameObject dialogue4;


    [SerializeField] private AudioClip breakInSound;
    [SerializeField] private AudioSource audioSource;

    public Collider2D breakCollider;

    public GameObject AlphaWolf;

    bool gameEnd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogue.SetActive(false);
        dialogue2.SetActive(false);
        dialogue3.SetActive(false);
        dialogue4.SetActive(false);
        AlphaWolf.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (AlphaWolf == null)
        {
            dialogue4.SetActive(true);
        }

        if (gameEnd)
        {

            dialogue4.SetActive(false);
            this.enabled = false;
        }

    }


    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))//Reads Notes
        {
            Time.timeScale = 0f;
            dialogue.SetActive(true);
        }

    }

    public void Break()//Shattering Glass
    {
        Time.timeScale = 0f;
        dialogue.SetActive(false);
        dialogue2.SetActive(true);
        audioSource.PlayOneShot(breakInSound);
        Destroy(dialogue);
    }


    public void Next()
    {
        Time.timeScale = 0f;
        dialogue2.SetActive(false);
        Destroy(dialogue2);
        dialogue3.SetActive(true);
        AlphaWolf.SetActive(true);

    }

    public void end()
    {
        Time.timeScale = 1f;
        dialogue3.SetActive(false);
        Destroy(dialogue3);
        Destroy(breakCollider);

    }

    public void GameEnd()
    {
        Time.timeScale = 1f;
        gameEnd = true;

    }
    


    }








