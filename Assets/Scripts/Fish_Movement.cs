using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Fish_Movement : MonoBehaviour
{
    Movement movement;  
    public float moveSpeed = 1.5f;
    private Rigidbody2D rb;


    void Awake()
    {
        movement = GameObject.Find("worm_hook_006").GetComponent<Movement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")   // When Player get fish hooked
        {
            if(movement.childs == 0)
            {
                moveSpeed = 0f;
            }
        }

        if (collision.GetComponent<Wall>()) // When fish gets out from the screen
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Respawn") // When player lifts fish up
        {
            Destroy(this.gameObject);
            // TODO: Player gets money (points) when this happens
        }

    }

    // Update is called once per frame
    void Update()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(moveSpeed, 0);
    }
}
