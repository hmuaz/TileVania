using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputD : MonoBehaviour
{
    public bool playerMoving = false;
    public bool startClimbing = false;
    public bool climbingA = false;
    public Ladder ladder;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            playerMoving = true;
        }
        else
        {
            playerMoving = false;
        }

        if (ladder.tirmanma)
        {
            if(Input.GetAxisRaw("Vertical") != 0)
            {
                startClimbing = true;
                climbingA = true;
            }
            else
            {
                startClimbing = false;
            }
        }
        
    }
}
