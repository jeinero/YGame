using UnityEngine;
using System.Collections;
using System;

public class Spawner : MonoBehaviour
{
    public GameManager score;
    float x;
    float y;
    float z;
    Vector3 pos;
    public GameObject objects;
    private int lvl = 1;
    public void SpawnRandom()
    {
        for (int i = 0; i < 10; i++)
        {
            x = UnityEngine.Random.Range(-100, 100);
            y = UnityEngine.Random.Range(-100, 100);
            z = 0;
            pos = new Vector3(x, y, z);
            transform.position = pos;
            Instantiate(objects, pos, Quaternion.identity);
            int lvlgive = UnityEngine.Random.Range(1, lvl);
            objects.GetComponent<Ennemi>().SetLvl(lvlgive);
            lvl += lvlgive;
            print(lvl);
        }
    }
    void Start()
    {
        SpawnRandom();
    }
}