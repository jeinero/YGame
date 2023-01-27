using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;
    public GameObject objects;
    private int lvl = 1;
    public void SpawnRandom()
    {

        x = Random.Range(-100, 100);
        y = Random.Range(-100, 100);
        z = 0;
        pos = new Vector3(x, y, z);
        transform.position = pos;

        Instantiate(objects, pos, Quaternion.identity);
        int lvlgive = Random.Range(1, lvl);
        objects.GetComponent<Ennemi>().SetLvl(lvlgive);
        lvl += lvlgive;
    }
    void Start()
    {
        SpawnRandom();
    }
}