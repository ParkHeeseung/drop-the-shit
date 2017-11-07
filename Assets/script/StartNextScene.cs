using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

    public void SceneChange1()
    {
        SceneManager.LoadScene("start");
    }

    public void SceneChage2()
    {
        SceneManager.LoadScene("stage1");
    }
}
