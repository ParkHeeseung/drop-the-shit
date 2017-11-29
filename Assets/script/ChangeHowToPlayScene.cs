using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeHowToPlayScene : MonoBehaviour
{

    public void SceneChange3()
    {
        SceneManager.LoadScene("start");
    }

    public void SceneChage4()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}

