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
        StartCoroutine(recycle());
    }

    // Update is called once per frame


    IEnumerator recycle()
    {
        while (true)
        {
            if (shit.position.y < 0)
            {
                transform.position = new Vector3(Random.Range(-40, 40), Random.Range(40, 60), Random.Range(-30, 30));
            }

            yield return new WaitForSeconds(0.2f);
        }
    }
}
