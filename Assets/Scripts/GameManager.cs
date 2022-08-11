using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gm;


    private void Start()
    {
        if(gm != null)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
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
