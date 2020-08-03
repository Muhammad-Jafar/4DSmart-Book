using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubScript : MonoBehaviour
{
    public GameObject textBox;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence(){
        yield return new WaitForSeconds(1f);
        textBox.GetComponent<Text>().text = "Hello";
        yield return new WaitForSeconds(1.5f);
        textBox.GetComponent<Text>().text = "";
        // yield return new WaitForSeconds(2f);
        // textBox.GetComponent<Text>().text = "Good Day";
        // yield return new WaitForSeconds(4f);
        // textBox.GetComponent<Text>().text = "";
        // yield return new WaitForSeconds(5f);
        // textBox.GetComponent<Text>().text = "Babby";
        // yield return new WaitForSeconds(6f);
        // textBox.GetComponent<Text>().text = "";
    }
}
