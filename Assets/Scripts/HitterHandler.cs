using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Manages the hitters, player 1 and 2
public class HitterHandler : MonoBehaviour
{
    public bool isPlayerOne;
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    void Update()
    {
        if (isPlayerOne)
        {
            movement = Input.GetAxisRaw("Hitter1");
        }
        else
        {
            movement = Input.GetAxisRaw("Hitter2");
        }

        // Set velocity
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
