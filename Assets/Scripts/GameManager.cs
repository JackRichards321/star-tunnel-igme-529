using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour{
    public ParticleSystem EntireParticleStar;//the whole system
    public ParticleSystem MiddleLargeStar;
    public ParticleSystem TLStar;//top left star
    public ParticleSystem TMStar;//top middle star
    public ParticleSystem TRStar;//top right star
    public ParticleSystem BLStar;//bottom left star
    public ParticleSystem BMStar;//bottom middle star
    public ParticleSystem BRStar;//bottom right star
    private ParticleSystem.MainModule mainModuleMiddleLarge;
    public Material M_CircleGlowy;//circle shape
    public Material M_StarGlowy;//star shape
    public Material M_TrianGlowy;//triangle shape
    public Material M_HeartGlowy;//heart shape
    public Material M_SquareGlowy;//square shape
    public Material M_4PointGlowy;//shuriken shape
    public Material M_HexaGlowy;//hexagon shape
    public Material M_OctaGlowy;//jack black shape
    public Material M_DiamondGlowy;//diamond shape
    void Start(){//sets the middle star to be the star shape
        mainModuleMiddleLarge = MiddleLargeStar.main;
    }
    void Update(){//top row changes the color of the main shape
        if (Input.GetKeyDown(KeyCode.Q)||Input.GetKeyDown(KeyCode.W)){
            mainModuleMiddleLarge.startColor = Color.red;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.E)||Input.GetKeyDown(KeyCode.R)){
            mainModuleMiddleLarge.startColor = Color.yellow;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.T)||Input.GetKeyDown(KeyCode.Y)){
            mainModuleMiddleLarge.startColor = Color.green;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.U)||Input.GetKeyDown(KeyCode.I)){
            mainModuleMiddleLarge.startColor = Color.blue;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.O)||Input.GetKeyDown(KeyCode.P)){
            mainModuleMiddleLarge.startColor = Color.white;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.A)){//middle row changes the main shape
            MiddleLargeStar.GetComponent<ParticleSystemRenderer>().material = M_CircleGlowy;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.S)){
            MiddleLargeStar.GetComponent<ParticleSystemRenderer>().material = M_SquareGlowy;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.D)){
            MiddleLargeStar.GetComponent<ParticleSystemRenderer>().material = M_TrianGlowy;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.F)){
            MiddleLargeStar.GetComponent<ParticleSystemRenderer>().material = M_HexaGlowy;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.G)){
            MiddleLargeStar.GetComponent<ParticleSystemRenderer>().material = M_OctaGlowy;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.H)){
            MiddleLargeStar.GetComponent<ParticleSystemRenderer>().material = M_DiamondGlowy;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.J)){
            MiddleLargeStar.GetComponent<ParticleSystemRenderer>().material = M_StarGlowy;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.K)){
            MiddleLargeStar.GetComponent<ParticleSystemRenderer>().material = M_4PointGlowy;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.L)){
            MiddleLargeStar.GetComponent<ParticleSystemRenderer>().material = M_HeartGlowy;
            EntireParticleStar.Play();
        } else if (Input.GetKeyDown(KeyCode.Z)){//the bottom row lets you unleash one of the six small stars individually
            TLStar.Play();
        } else if (Input.GetKeyDown(KeyCode.X)){
            TMStar.Play();
        } else if (Input.GetKeyDown(KeyCode.C)){
            TRStar.Play();
        } else if (Input.GetKeyDown(KeyCode.V)){//unleashes all small stars at once
            TLStar.Play();
            TMStar.Play();
            TRStar.Play();
            BLStar.Play();
            BMStar.Play();
            BRStar.Play();
        } else if (Input.GetKeyDown(KeyCode.B)){
            BLStar.Play();
        } else if (Input.GetKeyDown(KeyCode.N)){
            BMStar.Play();
        } else if (Input.GetKeyDown(KeyCode.M)){
            BRStar.Play();
        }
    }
}