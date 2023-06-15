using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x * speed , 0);
    }

    void Update()
    {
        float directionX = Input.GetAxis("Horizontal");
        playerDirection = new Vector2(directionX, 0).normalized;
    }
}
