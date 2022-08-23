using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLevel2 : MonoBehaviour
{
    Player player;
    InputD id;
    Die dieScript;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        id = GameObject.Find("LevelManager").GetComponent<InputD>();
        dieScript = GameObject.Find("Player").GetComponent<Die>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && id.playerRolling == false)
        {
            dieScript.PlayerDieLevel2();
        }


    }
}
