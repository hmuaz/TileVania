using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Player player;
    Vector3 playerTransform;
    void Start()
    {
    }

    
    void Update()
    {
        playerTransform = player.transform.position;

        Debug.Log(playerTransform);
        Debug.Log(transform.position);

        float camx = Mathf.Clamp(playerTransform.x, -4.75f, 33.75f);
        float camy = Mathf.Clamp(playerTransform.y, 0, 1);

        this.transform.position = new Vector3(camx, camy, -10);
    }
}
