using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replay_sound : MonoBehaviour
{
   GameObject replayS, naga;
    void Start()
    {
        replayS = GameObject.Find("replay");
        naga = GameObject.Find("naga");
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                if(hit.collider.tag=="replay"){
                    naga.GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}
