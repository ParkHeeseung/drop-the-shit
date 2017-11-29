using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeStartScene : MonoBehaviour
{

    public void SceneChange5()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void SceneChage6()
    {
        SceneManager.LoadScene("Start");
    }
}

