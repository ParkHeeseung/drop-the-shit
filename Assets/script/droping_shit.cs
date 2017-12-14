using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droping_shit : MonoBehaviour {

    public int Speed;
    //float destroyTime = 3;
	// Use this for initialization
	void Start () {
      //  Destroy(gameObject, destroyTime);

    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
 
    }
}
