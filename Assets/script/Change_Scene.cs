using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{

    public void SceneChange1()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void SceneChange2()
    {
        SceneManager.LoadScene("Start");
    }

    public void SceneChange3()
    {
        SceneManager.LoadScene("stage1");
    }
}

