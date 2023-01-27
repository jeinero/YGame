using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private int _ennemysCount = 0;
    private Score score;
    private string scoresss = "score";

    public int EnnemyCount
    {
        get
        {
            return _ennemysCount;
        }
        set
        {
            _ennemysCount = value;
            CheckEnnemysCountLeft();
            SetInt(Getint()+2);
        }
    }

    private void CheckEnnemysCountLeft()
    {
        if (_ennemysCount <= 0)
        {
            SceneManager.LoadScene("LVL1");
        }
    }

    public void SetInt(int Value)
    {
        PlayerPrefs.SetInt(scoresss, Value);
    }
    public int Getint()
    {
        return PlayerPrefs.GetInt(scoresss);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
