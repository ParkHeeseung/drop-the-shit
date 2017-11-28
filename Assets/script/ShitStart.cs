using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShitStart : MonoBehaviour {

    public GameObject prefab;
    public float gridX = 5f;
    public float gridY = 5f;
    public float spacing = 2f;


    public void newObject()
    {
        GameObject createdObject = Instantiate(prefab, new Vector3(0, 25, 0), Quaternion.identity);
        createdObject.transform.position = new Vector3(Random.Range(55,65), Random.Range(51,57), 0);
        createdObject.transform.rotation = new Quaternion(10, 20, 0, 0);

    }

    void Start()
    {
        prefab = Resources.Load("shit") as GameObject;

        //Prefabs obj = Instantiate(shit);


        StartCoroutine(newobject());
    }

    IEnumerator newobject()
    {
        while (true)
        {
            for (int i = 0; i < 1; i++)
                newObject();

            yield return new WaitForSeconds(0.1f);
        }
    }


    void Update()
    {

    }
}
