using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float jumpSpeed = 5f;



    float movement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ziplama();
        

        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Hareket();

    }

    private void Hareket()
    {
        rb.velocity = new Vector2(movement * speed * Time.deltaTime, rb.velocity.y);



    }



    private void Ziplama()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);

        }
    }
}
