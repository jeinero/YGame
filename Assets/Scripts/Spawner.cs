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
<<<<<<< HEAD


        z = 0;
        for (int i = 0; i < score.Getint(); i++)
        {
            x = UnityEngine.Random.Range(-100, 100);
            y = UnityEngine.Random.Range(-100, 100);
=======
        for (int i = 0; i < 10; i++)
        {
            x = UnityEngine.Random.Range(-100, 100);
            y = UnityEngine.Random.Range(-100, 100);
            z = 0;
>>>>>>> 3e1463cc686a9dc22e907f40ec69c5ecb0551048
            pos = new Vector3(x, y, z);
            transform.position = pos;
            Instantiate(objects, pos, Quaternion.identity);
            int lvlgive = UnityEngine.Random.Range(1, lvl);
            objects.GetComponent<Ennemi>().SetLvl(lvlgive);
            lvl += lvlgive;
<<<<<<< HEAD
            score.EnnemyCount += 1;
=======
            print(lvl);
>>>>>>> 3e1463cc686a9dc22e907f40ec69c5ecb0551048
        }
    }
    void Start()
    {
        SpawnRandom();
    }
}