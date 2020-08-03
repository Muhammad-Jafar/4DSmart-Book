using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class delayforsentence : MonoBehaviour 

{
    public GameObject sentences;



    void Start()
    {
        if (sentences.SetActive != null)
        {
            Invoke("sentencehide", 7.0f);
        }
        else if (sentences.SetActive == null)
        {
           sentences.SetActive(true);
        }

        
    }

    public void sentencehide()
    {

        sentences.SetActive(false);

    }
}
