using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthBar : MonoBehaviour {

    public Slider hpBar;
    public bool check = true;

    void Start () {

        

	}
	
	
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        
       
        if ((other.gameObject.tag == "Respawn") && check)
        {
            
            hpBar.value -= 50;
            check = false;
        }

        if(hpBar.value == 0)
            SceneManager.LoadScene(10, LoadSceneMode.Single);

        StartCoroutine(WaitForIt());
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(1.5f);
        check = true;
    }
}
