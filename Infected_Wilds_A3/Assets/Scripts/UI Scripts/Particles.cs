using UnityEngine;

public class Particles : MonoBehaviour
{
    public new ParticleSystem particleSystem;

    [SerializeField]
    public Animator walk;


    void Start()
    {

    }

    void Update()
    {
        bool isWalking = walk.GetBool("IsMoving");

        if (isWalking)
        {
            WalkParticles();

        }
        else
        {
            StopParticles();


        }

    }




    public void WalkParticles()
    {

        particleSystem.Play();
    }

    public void StopParticles()
    {
        particleSystem.Stop();
    }
}
