using UnityEngine;

public class DeathParticles : MonoBehaviour
{

    public new ParticleSystem particleSystem;

        void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Death()
    {
        particleSystem.Play();
    }
    


}
