using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPrefab : MonoBehaviour {

    GameObject prefab;
    public int Penguin_count;

    public void newObject(){
        GameObject createdObject = Instantiate(prefab, new Vector3(0, 24, -8), Quaternion.identity);
        createdObject.transform.position = new Vector3(Random.Range(-40, 40), Random.Range(25, 50), Random.Range(-30, 30));
       // createdObject.transform.rotation = new Quaternion(10, 20, 0, 0);
    }

    void Start(){
        prefab = Resources.Load("Penguin") as GameObject;
        //Prefabs obj = Instantiate(shit);

        StartCoroutine(newobject());
    }

    IEnumerator newobject(){
        yield return new WaitForSeconds(5f);

        GameManager.Instance().gameReady = true;

        for (int i = 0; i < Penguin_count; i++)
        {
            newObject();
        }
       
    }

}
