using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isRightPlayer;
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (isRightPlayer)
        {
            movement = Input.GetAxisRaw("Player1");
        }
        else
        {
            movement = Input.GetAxisRaw("Player2");
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
