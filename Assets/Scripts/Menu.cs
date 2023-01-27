
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameManager manage;

    public void SwitchScene(string _sceneName)
    {
        SceneManager.LoadScene("LVL1");
        manage.SetInt(3);
    }

    public void Leave()
    {
        Application.Quit();
    }
}
