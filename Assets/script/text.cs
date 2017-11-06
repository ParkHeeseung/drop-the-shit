using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour {

    int size = 1;
    Text t;

	void Start () {
        t = GetComponent<Text> ();
	}
	
	void Update () {
        t.fontSize = Screen.height * size /10;
    
    }
}
