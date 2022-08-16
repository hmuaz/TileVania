using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    static LevelManager lm;


    private void Start()
    {
        if (lm != null)
        {
            Destroy(gameObject);
        }
        else
        {
            lm = this;
            GameObject.DontDestroyOnLoad(gameObject);

        }
    }
    public void Nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
