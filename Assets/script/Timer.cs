using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float TimeCost;
    int size = 1;
    void Start()
    {
        TimeCost = 30f;
    }

    void Update()
    {
        
        if (TimeCost != 0)
        {
            TimeCost -= Time.deltaTime;
            if (TimeCost <= 0)
                TimeCost = 0;


        }
        int t = Mathf.FloorToInt(TimeCost);
        Text TimeCount = GetComponent<Text>();
        TimeCount.text = "남은 시간 : " + t.ToString();
        TimeCount.fontSize = Screen.height * size / 10;

    }


}