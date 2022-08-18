using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    static UI ui;

    public int coinInt;
    Text scoreText;

    private void Start()
    {

        if(ui != null)
        {
            Destroy(gameObject);
        }
        else
        {
            ui = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    

    private void Update()
    {

        scoreText = GameObject.Find("Canvas").GetComponentInChildren<Text>();

        scoreText.text ="= " + coinInt.ToString();
    }
}
