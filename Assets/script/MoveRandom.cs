using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour {

    public Rigidbody obj;

	void Start () {
        StartCoroutine(MoveObject()); 
	}
	
	IEnumerator MoveObject()
    {
        obj = GetComponent<Rigidbody>();

        while (true)
        {
            float dir1 = Random.Range(-10f, 0);
            float dir2 = Random.Range(-3f, 3f);

            obj.velocity = new Vector3(dir1, 0, dir2);
            

            yield return new WaitForSeconds(1);
        }
    }
}
