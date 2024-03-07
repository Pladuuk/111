using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVFXManager : MonoBehaviour
{
    public static PlayerVFXManager instance;

    public ParticleSystem footStep;

    private void Awake()
    {
        instance = this;
    }
    
    public void FootStep()
    {
        footStep.Play();
    }
}
