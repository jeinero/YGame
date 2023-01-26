using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class Arrow : MonoBehaviour
{
    public GameObject Player;
    private GameObject Target;
    public Transform target2;
    private GameObject[] Ennemi;
    private float oldDistance = 9999;
    private Quaternion startRotation;
    private Quaternion endRotation;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        getClosestEnnemi();
        rotateDirection();
    }

    private void getClosestEnnemi()
    {
        Ennemi = GameObject.FindGameObjectsWithTag("Ennemi");
        foreach (GameObject obj in Ennemi)
        {
            float dist = Vector3.Distance(Player.gameObject.transform.position, obj.transform.position);
            if (dist < oldDistance)
            {
                Target = obj;
                oldDistance = dist;
            }
        }
    }
    private void rotateDirection()
    {
        //float Y =  (Target.transform.position.y) - Player.transform.position.y;
        //float X =  (Target.transform.position.x) - Player.transform.position.x; 
        //float angle = (Mathf.Asin(Y/(Y + X)) * Mathf.Rad2Deg);
        //this.transform.eulerAngles = new(0, 0, angle);
        //Vector3 dir = Target.transform.position - Player.transform.position;
        //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //transform.eulerAngles = new(0f, 0f, angle);
        //transform.rotation = Quaternion.LookRotation(Vector3.up, dir);
        //Vector3 pos = Target.transform.position;
        //pos.z = transform.position.z;
        //transform.LookAt(pos, Vector3.up);
        //transform.rotation = Quaternion.Slerp(rb.transform.rotation,
        //   Quaternion.Euler(0, 0, angle), 0.7f);
    }
}
