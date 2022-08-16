using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public bool tirmanma = false;
    public Player p;
    public InputD id;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            tirmanma = true;
            p.rb.drag = 100;
            p.rb.gravityScale = 0;

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tirmanma = false;
            id.startClimbing = false;
            p.rb.drag = 0;
            p.rb.gravityScale = 40;
            id.climbingA = false;
        }
    }
}


