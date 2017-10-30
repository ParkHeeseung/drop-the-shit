using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabs : MonoBehaviour
{


    public GameObject prefab;
    public float gridX = 5f;
    public float gridY = 5f;
    public float spacing = 2f;

    public void newObject()
    {
        GameObject createdObject = Instantiate(prefab, new Vector3(0, 24, -8), Quaternion.identity);
        createdObject.transform.position = new Vector3(Random.Range(-100, 100), 24, Random.Range(-100, 100));
    }

    void Start()
    {
        prefab = Resources.Load("shit") as GameObject;
        //Prefabs obj = Instantiate(shit);


        StartCoroutine(newobject());
    }

        IEnumerator newobject(){
        while (true)
        {
            for (int i = 0; i < 700; i++)
            {
                newObject();
            }
            yield return new WaitForSeconds(3);
        }
        }

    
          //  for (int i = 0; i < 100; i++)
          //  {
         //       newObject();
          //  }

       
    

    void Update()
    {

    }
 
}