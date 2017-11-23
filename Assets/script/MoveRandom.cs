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
            float dir1 = Random.Range(-15f, 15f);
            float dir2 = Random.Range(-6f, 6f);

            obj.velocity = new Vector3(dir1, 0, dir2);

            obj.transform.rotation = new Quaternion(0, Random.Range(0, 90), 0, 0);

            //if(obj.position.x >20)

            
            //if (obj.position.x > 20 || obj.position.z > 20 || obj.position.x < -20 || obj.position.z < -20)
              //  obj.transform.position= new Vector3(0, 7, 0);

            yield return new WaitForSeconds(1);
        }
    }
}
