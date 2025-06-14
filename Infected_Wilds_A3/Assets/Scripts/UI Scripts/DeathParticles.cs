using UnityEngine;

public class DeathParticles : MonoBehaviour
{

    public ParticleSystem deathParticles;

        void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Death()
    {
        deathParticles.Play();
        Debug.Log("I DIED");
    }
    


}
