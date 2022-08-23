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
        ui.Lives = 3;
        ui.coinInt = 0;
        SceneManager.LoadScene(0);
    }

   
}
