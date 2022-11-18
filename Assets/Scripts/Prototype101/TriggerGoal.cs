using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGoal : MonoBehaviour
{
    public GameObject Roboter;
    public ParticleSystem playParticlesSystem;
    public ParticleSystem emitParticlesSystem;

    public AudioClip goalSFX;
    private AudioSource WinSound;


    void Start() 
    {
        WinSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        //Debug.Log(other.name + " triggered into " + gameObject.name);

        if (other.name == Roboter.name)
        {
            //when roboter collides with goal
            Debug.Log("Victory");
            
            //Play Win Sound
            WinSound.PlayOneShot(goalSFX);
            //Using a ParticleSystem for emission
            EmitParticles();
            //Using a ParticleSystem with Play and Stop - true
            PlayParticles(true);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.name == Roboter.name)
        {
            //Using a ParticleSystem with Play and Stop - false
            PlayParticles(false);
        }
    }

    void EmitParticles()
    {
        emitParticlesSystem.Emit(100);
    }

    void PlayParticles(bool on)
    {
        if (on)
        {
            playParticlesSystem.Play();
        }
        else if (!on)
        {
            playParticlesSystem.Stop();
        }    
    }
}
