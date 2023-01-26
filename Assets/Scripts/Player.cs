using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerScore = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ennemie")
        {
            Destroy(collision.gameObject);
            playerScore++;
        }
        else
        {
            
        }
    }
  
}
