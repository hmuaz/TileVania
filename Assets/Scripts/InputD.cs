using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputD : MonoBehaviour
{
    public bool playerRolling = false;
    public bool playerMoving = false;
    public bool startClimbing = false;
    public bool climbingA = false;
    public bool isJump = false;
    public Ladder ladder;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetAxisRaw("Horizontal") != 0 & playerRolling == false)
        {

            playerMoving = true;
        }
        else
        {
            playerMoving = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftControl) & isJump == false)
        {
            playerRolling = true;
            StartCoroutine(RollingFalse());
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
        
        IEnumerator RollingFalse()
        {
            yield return new WaitForSeconds(0.3f);
            playerRolling = false;
            
        }
    }
}
