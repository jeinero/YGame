using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private Score scoreComponent;
    private int _ennemysCount = 0;

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
            scoreComponent.UpdateScore(1);
        }
    }

    private void Awake()
    {
        scoreComponent = FindObjectOfType<Score>();
    }

    private void CheckEnnemysCountLeft()
    {
        if (_ennemysCount <= 0)
        {
            SceneManager.LoadScene("LVL1");
        }
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
