﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotalIn : MonoBehaviour {

    public Transform TranslatePosition;
    private AudioSource audio;
    public AudioClip potalSound;
    
	void OnTriggerEnter(Collider _col)
    {
        if(_col.gameObject.tag == "Player")
        {
            Transform ParentTransform = _col.transform;
            /*(while (true)
            {
                if (ParentTransform.parent == null)
                    break;
                else
                    ParentTransform = ParentTransform.parent;
       
            }*/
            ParentTransform.position = TranslatePosition.position;
            ParentTransform.rotation = TranslatePosition.rotation;

        }
    }

    void Start()
    {

    }
        
}
