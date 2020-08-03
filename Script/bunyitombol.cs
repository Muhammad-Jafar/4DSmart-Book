using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunyitombol : MonoBehaviour
{
    public AudioClip suaratombol;
    AudioSource audioSource;
    private float timer;

    void awake()
    {
        audioSource = GetComponent<AudioSource>();

    }

    
    void Update()
    {
        timer += Time.deltaTime;

    }

    public void KlikAudio()
    {
        if(timer >= 3)
        {
            timer = 0;
            audioSource.clip = suaratombol;
            audioSource.Play();
        }
    }
}
