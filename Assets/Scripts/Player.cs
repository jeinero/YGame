using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float level;
    public TextMeshProUGUI showLevel;
    // Start is called before the first frame update
    void Start()
    {
        this.level = 1;
        showLevel.text = $"LVL: {this.level}";
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 direction = new(horizontal, vertical);
        Move(direction);

    }

    private void Move(Vector3 direction)
    {
        transform.position += 0.25f * direction;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered");
        if(this.level >= collision.gameObject.GetComponent<Ennemi>().lvl)
        {
            this.level += collision.gameObject.GetComponent<Ennemi>().lvl;
            showLevel.text = $"LVL: {this.level}";
            Destroy(collision.gameObject);
        }
        else
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Defeat");
        }
        //
    }

}
