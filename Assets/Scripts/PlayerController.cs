using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D Controls;

    public float speed;
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            Controls.velocity = new Vector2(speed, 0f);
        }

        else if (Input.GetAxis("Horizontal") < 0)
        {
            Controls.velocity = new Vector2(-speed, 0f);
        }

        else if (Input.GetAxis("Vertical") > 0)
        {
            Controls.velocity = new Vector2(0f, speed);
        }

        else if (Input.GetAxis("Vertical") < 0)
        {
            Controls.velocity = new Vector2(0f, -speed);
        }

        else if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
        {
            Controls.velocity = new Vector2(0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Finish")
        {
            Debug.Log("level complaeted");
        }
        
    }
}
