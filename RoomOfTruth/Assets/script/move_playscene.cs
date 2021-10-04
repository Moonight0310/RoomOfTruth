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
}
