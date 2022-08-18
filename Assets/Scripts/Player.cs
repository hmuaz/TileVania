using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float climbingSpeed = 10f;
    public float jumpSpeed = 5f;
    public bool isJump = false;
    public LevelManager lm;
    public InputD id;
    [SerializeField] Movement mv;
    public Ladder ladder;
    public Animator anim;



    public float movementY;
    public float movementX;
    // Start is called before the first frame update
    void Start()
    {
        lm = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        id = GameObject.Find("LevelManager").GetComponent<InputD>();

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
        movementY = Input.GetAxisRaw("Vertical");


        anim.SetBool("isClimbing", id.climbingA);
        anim.SetBool("isMoving", id.playerMoving);
    }

    private void FixedUpdate()
    {
        if (id.playerMoving)
        {
            mv.Move(movementX, speed);
        }

        if (id.startClimbing)
        {
            if (movementY > 0)
            {
                ClimbingUp();
            }
            else if (movementY < 0)
            {
                ClimbingDown();
            }
        }
    }

    private void ClimbingUp()
    {
        rb.velocity = new Vector2(rb.velocity.x, movementY * speed * 2 * Time.deltaTime);
    }

    private void ClimbingDown()
    {
        rb.velocity = new Vector2(rb.velocity.x, movementY * speed * 2 * Time.deltaTime);


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
