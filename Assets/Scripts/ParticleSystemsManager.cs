using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemsManager : MonoBehaviour
{



    //Particles
    [SerializeField] private ParticleSystem particleSystem1;
    private ParticleSystem particleSystem1Instance;
    [SerializeField] private ParticleSystem particleSystem2;
    private ParticleSystem particleSystem2Instance;
    [SerializeField] private ParticleSystem particleSystem3;
    private ParticleSystem particleSystem3Instance;

    private void OnEnable()
    {
        Manager.ClickedOnMainButton += Manager_ClickedOnMainButton;
    }

    private void Manager_ClickedOnMainButton(object sender, int e)
    {
        switch (e)
        {
            case 0:
                return;
            case 1:
                if(particleSystem1Instance == null)
                    SpawnParticleSystem1();
                return;
            case 2:
                if (particleSystem2Instance == null)
                    SpawnParticleSystem2();
                return;
            default:
                if (particleSystem3Instance == null)
                    SpawnParticleSystem3();
                return;
        }
    }

    private void SpawnParticleSystem1()
    {
        particleSystem1Instance = Instantiate(particleSystem1, transform.position, transform.rotation);
    }

    private void SpawnParticleSystem2()
    {
        particleSystem2Instance = Instantiate(particleSystem2, transform.position, transform.rotation);
    }

    private void SpawnParticleSystem3()
    {
        particleSystem3Instance = Instantiate(particleSystem3, transform.position, transform.rotation);
    }
}
