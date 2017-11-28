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
        
            if (obj.position.x > 50)
            {
                obj.transform.Rotate(0, 180, 0);
                obj.velocity = -obj.transform.right * 15;
            }
            else if (obj.position.x < -70)
            {
                obj.transform.Rotate(0, 180, 0);
                obj.velocity = -obj.transform.right * 15;
            }
            else if (obj.position.z > 40)
            {
                obj.transform.Rotate(0, 180, 0);
                obj.velocity = -obj.transform.right * 15;
            }
            else if (obj.position.z < -40)
            {
                obj.transform.Rotate(0, 180, 0);
                obj.velocity = -obj.transform.right * 15;
            }
            else
            {
                obj.transform.Rotate(0, Random.Range(0, 360), 0);
                obj.velocity = -obj.transform.right * Random.Range(5f, 10f);
            }

            yield return new WaitForSeconds(2);
        }
    }
}
