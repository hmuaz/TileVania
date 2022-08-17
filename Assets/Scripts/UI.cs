using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public int coinInt;
    [SerializeField] Text scoreText;

    
    private void Update()
    {
        scoreText.text ="= " + coinInt.ToString();
    }
}
