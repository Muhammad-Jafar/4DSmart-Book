using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Coconut_TrySound : MonoBehaviour, IVirtualButtonEventHandler
{
  public GameObject Coco_AudioBtn;
    public AudioSource Coco_AudioSrc;

    // Start is called before the first frame update
    void Start()
    {
        Coco_AudioBtn = GameObject.Find("Coconut_TryAudioBtn");
        Coco_AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Coco_AudioSrc = GameObject.Find("Coconut_AudioSound").GetComponent<AudioSource>();

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        Coco_AudioSrc.Play();
        Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        Coco_AudioSrc.Play();
        Debug.Log("BTN Realesed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
