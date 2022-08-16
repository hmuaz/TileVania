using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float jumpSpeed = 5f;
    public bool isJump = false;
    public LevelManager lm;
    public InputD id;
    [SerializeField] Movement mv;
    public Animator anim;




    float movementX;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        if(movementX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(movementX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        movementX = Input.GetAxisRaw("Horizontal");
        anim.SetBool("isMoving", id.playerMoving);
    }

    private void FixedUpdate()
    {
        if (id.playerMoving)
        {
            mv.Move(movementX, speed);
        }

    }

    



    private void Jump()
    {
        if (!isJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isJump = false;
        }

        
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJump = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "StartGame")
        {
            lm.Nextlevel();
        }
        if (trigger.gameObject.tag == "Su")
        {
            rb.freezeRotation = false;
            for (int i = 40; i <= 0; i--)
            {
                rb.gravityScale = i;
            }
        }
    }
}
