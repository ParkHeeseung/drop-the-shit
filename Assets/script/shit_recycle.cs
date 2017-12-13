using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shit_recycle: MonoBehaviour {

    public Transform shit;
    Vector3 pos;

    // Use this for initialization
    void Start()
    {
        shit = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.gameObject.transform.position;

        recycle();


    }

    void recycle()
    {
        if (pos.y < 0)
        {
            transform.position = new Vector3(Random.Range(-40, 40), 100, Random.Range(-30, 30));
        }
    }
}
