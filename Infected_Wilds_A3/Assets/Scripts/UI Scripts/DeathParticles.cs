using UnityEngine;

public class DeathParticles : MonoBehaviour
{

    public ParticleSystem particleSystem;

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
        Debug.Log("I DIED");
    }
    


}
