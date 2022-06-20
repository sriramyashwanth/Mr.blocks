using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D Controls;
    public GameObject Game_won_pannel;
    private bool isGameover;
    public GameObject Game_lost_pannel;
    public float speed;
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameover == true)
        {
            return;
        }

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
            Game_won_pannel.SetActive(true);
            Debug.Log("level complaeted");
            isGameover = true;
        }

        if (collision.tag == "enemy")
        {
            Game_lost_pannel.SetActive(true);
            Debug.Log("level lost");
            isGameover = true;
        }
    }

    public void Restart()
    {
        EditorSceneManager.LoadScene(0);
        Debug.Log("clicked restart");
    }
}
