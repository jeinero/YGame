using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void SwitchScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void Leave()
    {
        Application.Quit();
    }
}
