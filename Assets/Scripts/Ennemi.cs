using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ennemi : MonoBehaviour
{
    public GameManager count;
    public TextMeshProUGUI showLevel;
    public int lvl;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void SetLvl(int lvl)
    {
        this.lvl = lvl;
        showLevel.text = $"LVL: {this.lvl}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
