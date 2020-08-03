using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Vuforia;

public class TimerforText : MonoBehaviour
{

    // private TrackableBehaviour mTrackableBehaviour;
    // public UnityEvent myStartEvent;
    // public UnityEvent myStopEvent;

    // public float time = 3;
    public GameObject textBox;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSentences());
        // TextSentences = GameObject.Find("Sentences");
        // yield return new WaitForSeconds(time);

    }

    IEnumerator TheSentences(){
        // TextSentences = GameObject.Find("Text");
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Hello";
        yield return new WaitForSeconds(3);
         textBox.GetComponent<Text>().text = "Hello";


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
