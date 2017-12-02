using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    static GameManager _instnace; 
    static public GameManager Instance() { return _instnace; }

    public bool gameReady = false;

    // Use this for initialization
    void Start () {
        _instnace = this;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
