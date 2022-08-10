using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Player player;
    Vector3 playerTransform;
    void Start()
    {
        playerTransform = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //float camx = Mathf.Clamp(playerTransform, )
        //transform.position = new Vector3()
    }
}
