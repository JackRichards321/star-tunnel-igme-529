using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ParticleSystem EntireParticleStar;
    public ParticleSystem MiddleLargeStar;
    private ParticleSystem.MainModule mainModuleMiddleLarge;
    public Material M_CircleGlowy;

    void Start()
    {
        mainModuleMiddleLarge = MiddleLargeStar.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            EntireParticleStar.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {

            mainModuleMiddleLarge.startColor = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            MiddleLargeStar.GetComponent<ParticleSystemRenderer>().material = M_CircleGlowy;
        }
    }
}
