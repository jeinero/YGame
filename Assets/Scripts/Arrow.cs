using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class Arrow : MonoBehaviour
{
    public GameObject Player;
    private GameObject Target;
    private GameObject[] Ennemi;
    private float oldDistance = 9999;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        getClosestEnnemi();
        if (Target != null)
        {
            rotateDirection();

        }
    }

    private void getClosestEnnemi()
    {
        Ennemi = GameObject.FindGameObjectsWithTag("Ennemi");
        if (Ennemi.Length == 0)
        {
            return;
        }
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
        float XRepereJoueur = ((Target.transform.position.y - Player.transform.position.y));
        float YRepereJoueur = -1 * ((Target.transform.position.x - Player.transform.position.x));
        float angle = Mathf.Asin(YRepereJoueur / Mathf.Sqrt(Mathf.Pow(YRepereJoueur, 2) + Mathf.Pow(XRepereJoueur, 2)));
        angle = angle * Mathf.Rad2Deg;
        if (Target.transform.position.y < Player.transform.position.y)
        {
            angle -= 180;
            angle *= -1;
        }
        this.transform.eulerAngles = new(0, 0, angle);
    }
}
