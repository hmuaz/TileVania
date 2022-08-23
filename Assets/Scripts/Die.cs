using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }
    public void PlayerDieLevel1()
    {
        player.transform.position = new Vector3(-12, 2, 0);
        player.ui.Lives--;

    }

    public void PlayerDieLevel2()
    {
        player.transform.position = new Vector3(-19, 9, 0);
        player.ui.Lives--;

    }
}
