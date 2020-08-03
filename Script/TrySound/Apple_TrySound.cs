using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Apple_TrySound : MonoBehaviour, IVirtualButtonEventHandler
{
  public GameObject Apple_AudioBtn;
    public AudioSource Apple_AudioSrc;

    // Start is called before the first frame update
    void Start()
    {
        Apple_AudioBtn = GameObject.Find("Apple_TryAudioBtn");
        Apple_AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Apple_AudioSrc = GameObject.Find("Apple_AudioSound").GetComponent<AudioSource>();

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        Apple_AudioSrc.Play();
        Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        Apple_AudioSrc.Play();
        Debug.Log("BTN Realesed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
