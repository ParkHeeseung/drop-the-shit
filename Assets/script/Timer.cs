using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    float TimeCost;
    int size = 1;
    void Start()
    {
        TimeCost = 30f;
    }

    void Update()
    {
        
        if (TimeCost != 0 && GameManager.Instance().gameReady == true )
        {
            TimeCost -= Time.deltaTime;
            if (TimeCost <= 0)
                TimeCost = 0;


        }
        //표시 시간나타냄
        float t = TimeCost; //Mathf.FloorToInt(TimeCost);
        Text TimeCount = GetComponent<Text>();
        TimeCount.text = "남은 시간 : " + t.ToString();
        TimeCount.fontSize = Screen.height * size / 10;

        if(TimeCost == 0)
        {
            SceneManager.LoadScene(5, LoadSceneMode.Single);
        }

    }


}