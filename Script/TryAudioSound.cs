using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TryAudioSound : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject AudioBtn;
    public AudioSource AudioSrc;

    // Start is called before the first frame update
    void Start()
    {
        AudioBtn = GameObject.Find("TryAudioBtn");
        AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        AudioSrc = GameObject.Find("AudioSound").GetComponent<AudioSource>();

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        AudioSrc.Play();
        Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        AudioSrc.Play();
        Debug.Log("BTN Realesed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
