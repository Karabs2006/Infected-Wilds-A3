using UnityEngine;
public class Audio : MonoBehaviour
{
    public AudioClip[] Clips;
    public AudioSource audioSource;
    public ButtonSoundType soundType;

    public enum ButtonSoundType
    {
        Next,
        Play,
        Scifi
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

     public void PlaySound(ButtonSoundType soundType)
    {
        switch (soundType)
        {
            case ButtonSoundType.Next:
            audioSource.PlayOneShot(Clips[0]);
            break;

            case ButtonSoundType.Play:
            audioSource.PlayOneShot(Clips[1]);
            break;

            case ButtonSoundType.Scifi:
            audioSource.PlayOneShot(Clips[2]);
            break;
    }

    
    }

    public void PlayAssignedSound()
    {
        PlaySound(soundType);
    }
}
