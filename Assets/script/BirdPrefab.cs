using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPrefab : MonoBehaviour {

    GameObject prefab;
    public int Penguin_count;

    public void newObject(){
        GameObject createdObject = Instantiate(prefab, new Vector3(Random.Range(-40, 40), Random.Range(25, 50), Random.Range(-30, 30)), Quaternion.identity);
        
    }

    void Start(){
        prefab = Resources.Load("Penguin") as GameObject;
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
