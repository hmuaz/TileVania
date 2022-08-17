using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Move(float movement, float speed)
    {
        rb.velocity = new Vector2(movement * speed * Time.fixedDeltaTime, rb.velocity.y);
    }
}
