using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputD : MonoBehaviour
{
    public bool playerMoving = false;
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
        
    }
}
