using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class REPLAY : MonoBehaviour
{

    public void SceneChange7()
    {
        SceneManager.LoadScene("gameover");
    }

    public void SceneChage8()
    {
        SceneManager.LoadScene("Start");
    }
}

