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
        GameObject createdObject = Instantiate(prefab, new Vector3(0, 25, 0), Quaternion.identity);
        createdObject.transform.position = new Vector3(Random.Range(-80, 120), Random.Range(25, 50), Random.Range(-30, 30));
        createdObject.transform.rotation = new Quaternion(10, 20, 0, 0);
        
    }

    void Start()
    {
        prefab = Resources.Load("shit") as GameObject;

        //Prefabs obj = Instantiate(shit);


        StartCoroutine(newobject());
    }

        IEnumerator newobject(){
        yield return new WaitForSeconds(1f);
        
        while (true)
        {
            for (int i=0; i<1; i++)
                newObject();
      
            yield return new WaitForSeconds(0.7f);
        }
        }
    

    void Update()
    {
        
    }
 
}