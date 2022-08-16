using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public LevelManager lm;
    public void GameOver()
    {
        lm.RestartLevel();
    }
}
