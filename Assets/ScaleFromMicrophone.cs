using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromMicrophone : MonoBehaviour
{
    public AudioSource source;
    public float minSpeed;
    public float maxSpeed;
    public AudioLoudnessDetection detector;
    private ParticleSystem ps;

    public float loudnessSensibility = 100;
    public float threshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;

        if (loudness < threshold) loudness = 0;

        var main = ps.main;

        //lerp value from minSpeed to maxSpeed
        main.simulationSpeed = Mathf.Lerp(minSpeed, maxSpeed, loudness);
        //ps.playbackSpeed = Mathf.Lerp(minSpeed, maxSpeed, loudness);
    }
}
