﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class TextBlink2 : MonoBehaviour
{
    Text flashingText;

    // Use this for initialization
    void Start()
    {
        flashingText = GetComponent<Text>();
        StartCoroutine(BlinkText());


    }

    // Update is called once per frame
    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(.5f);
            flashingText.text = "HOW TO PLAY";
            yield return new WaitForSeconds(.5f);
        }
    }
}