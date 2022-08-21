using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{
    [SerializeField] float rollingSpeed = 10f;
    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Roll(float direction)
    {
        rb.velocity = Direction(direction) * rollingSpeed * Time.deltaTime;


    }

    Vector2 Direction(float direction)
    {
       Vector2 yon = new Vector2(direction, 0);
       return yon;
    } 
}
