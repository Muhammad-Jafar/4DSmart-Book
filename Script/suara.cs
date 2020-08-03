using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suara : MonoBehaviour
{
    
private CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    if(cc.isGrounded == true && GetComponent<AudioSource>().isPlaying == false)
      {
        GetComponent<AudioSource>().Play();
      }
    }
}
