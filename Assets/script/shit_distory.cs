using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shit_distory : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            Transform ParentTransform =  other.transform;
            ParentTransform.position = new Vector3(400, 400, 400);

        }
            
    }
    
}
