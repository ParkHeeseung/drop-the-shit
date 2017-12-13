using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TextBlink : MonoBehaviour {
    Text flashingText;

	// Use this for initialization
	void Start () {
        StartCoroutine (BlinkText());

		
	}
	
	// Update is called once per frame
    IEnumerator BlinkText()
    {
        flashingText = GetComponent<Text>();
        string copy_text = flashingText.text;

        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(.5f);
            flashingText.text = copy_text;
            yield return new WaitForSeconds(.5f);
        }
    }
}
