using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameManager manage;

    public void SwitchScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
        manage.SetInt(3);
    }

    public void Leave()
    {
        Application.Quit();
    }
}
