﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPrefab : MonoBehaviour {

    public GameObject prefab;
    public float gridX = 5f;
    public float gridY = 5f;
    public float spacing = 2f;

    public void newObject()
    {
        GameObject createdObject = Instantiate(prefab, new Vector3(0, 24, -8), Quaternion.identity);
        createdObject.transform.position = new Vector3(Random.Range(-40, 40), Random.Range(25, 50), Random.Range(-30, 30));
       // createdObject.transform.rotation = new Quaternion(10, 20, 0, 0);
    }

    void Start()
    {
        prefab = Resources.Load("Penguin") as GameObject;
        //Prefabs obj = Instantiate(shit);

        StartCoroutine(newobject());
    }

    IEnumerator newobject(){
        yield return new WaitForSeconds(5f);

        for (int i = 0; i < 200; i++)
        {
            newObject();
        }
        yield return new WaitForSeconds(0.7f);
    }

    void Update()
    {

    }

}
