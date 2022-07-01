using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles ball launch/velocity/reset
public class BallHandler : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float x;
    private float y;

    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    private void Launch()
    {
        // If random range is between 0 and 2 and equal zero, change position to -1 and 1
        if (Random.Range(0, 2) == 0)
        {
            x = -1;
        }
        else
        {
            x = 1;
        }

        // Allows ball to launch in 4 directions
        if (Random.Range(0, 2) == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }

        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero; transform.position = startPosition;
        Launch();
    }


}
