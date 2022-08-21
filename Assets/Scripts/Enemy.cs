using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyMovement = 1f;
    public float enemySpeed = 70f;
    Movement movementScript;
    public GameManager gm;
    InputD id;



    private void Awake()
    {
        id = GameObject.Find("LevelManager").GetComponent<InputD>();
        movementScript = GetComponent<Movement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" & id.playerRolling == false)
        {
            Debug.Log("temas");
            gm.GameOver();
        }

        if (collision.gameObject.tag == "EnemyYon")
        {
            if(enemyMovement == 1)
            {
                transform.localScale = new Vector3(-1, 1, 1);

                enemyMovement = -1;
            }
            else if(enemyMovement == -1)
            {
                transform.localScale = new Vector3(1, 1, 1);

                enemyMovement = 1;
            }
        }

        

    }

    

    private void Update()
    {
    }


    private void FixedUpdate()
    {
        movementScript.Move(enemyMovement, enemySpeed);

    }
}
