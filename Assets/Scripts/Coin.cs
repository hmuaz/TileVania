using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public UI ui;

    private void Awake()
    {
        ui = GameObject.Find("Skor").GetComponent<UI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ui.coinInt++;
            Destroy(gameObject);
        }
    }
}
