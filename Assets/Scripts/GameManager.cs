using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public LevelManager lm;
    [SerializeField] UI ui;

    private void Awake()
    {
        ui = GameObject.Find("Skor").GetComponent<UI>();
    }
    public void GameOver()
    {
        ui.coinInt = 0;
        lm.RestartLevel();
    }
}
