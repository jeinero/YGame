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
    public GameObject[] objects;

    public void SpawnRandom()
    {

        x = UnityEngine.Random.Range(-100, 100);
        y = UnityEngine.Random.Range(-100, 100);
        z = 0;
        pos = new Vector3(x, y, z);
        transform.position = pos;



        // Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], pos, Quaternion.identity);

        for (int i = 0; i < score.Getint(); i++)
        {
            Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], pos, Quaternion.identity);
        }
    }
    private int Getint(string KeyName)
    {
        return PlayerPrefs.GetInt(KeyName);
    }
    void Start()
    {
        SpawnRandom();
    }
}