using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;
    public GameObject[] objects;

    public void SpawnRandom()
    {

        x = Random.Range(-100, 100);
        y = Random.Range(-100, 100);
        z = 0;
        pos = new Vector3(x, y, z);
        transform.position = pos;

        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], pos, Quaternion.identity);
    }
    void Start()
    {
        SpawnRandom();
    }
}