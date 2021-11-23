using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move_playscene : MonoBehaviour
{

    public void Click()
    {
        SceneManager.LoadScene("play_scene");
    }
    public void Click2()
    {
        SceneManager.LoadScene("main_scene");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
