using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
    public AudioSource source1;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("Laciebtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        source1 = GameObject.Find("AudioMusic").GetComponent<AudioSource>();

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        source1.Play();
        Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        source1.Play();
        Debug.Log("BTN Realesed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
