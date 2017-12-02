using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage_for_2: MonoBehaviour
{
    void OnTriggerEnter(Collider _col)
    {
        if (_col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single); 
        }
    }
}