using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShitStart : MonoBehaviour {

    public GameObject prefab;


    public void newObject(int i)
    {
        GameObject createdObject = Instantiate(prefab, new Vector3(0, 25, 0), Quaternion.identity);
        createdObject.transform.position = new Vector3(80, 40, 0);
        createdObject.transform.rotation = new Quaternion(-10, -10, -4+(i/5), -4+(i/5));

    }

    void Start()
    {
        prefab = Resources.Load("Penguin_start") as GameObject;

        //Prefabs obj = Instantiate(shit);


        StartCoroutine(newobject());
    }

    IEnumerator newobject()
    {
        for (int i = 0; i < 40; i++)
        {
             newObject(i);
             yield return new WaitForSeconds(0.01f);
        }

        for (int i = 40; i > 0; i--)
        {
            newObject(i);
            yield return new WaitForSeconds(0.01f);
        }

    }


    void Update()
    {

    }
}
