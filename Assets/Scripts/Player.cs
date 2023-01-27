using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float level;
    public TextMeshProUGUI showLevel;
    // Start is called before the first frame update
    void Start()
    {
        //this.level = 0;
        //showLevel.text = $"LVL: {this.level}";
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
}
