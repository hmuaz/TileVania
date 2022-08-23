using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveManager : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] GameObject canvas;
    public Transform live1;
    public Transform live2;
    public Transform live3;

    

    

    private void Update()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        canvas = GameObject.Find("Canvas");
        live1 = canvas.transform.Find("Live1");
        live2 = canvas.transform.Find("Live2");
        live3 = canvas.transform.Find("Live3");

        if (player.ui.Lives == 3)
        {
            live1.localPosition = new Vector3(-365, 190, 0);

            live2.localPosition = new Vector3(-330, 190, 0);

            live3.localPosition = new Vector3(-295, 190, 0);
        }

        if (player.ui.Lives == 2)
        {
            live1.localPosition = new Vector3(-365, 190, 0);

            live2.localPosition = new Vector3(-330, 190, 0);

            live3.localPosition = new Vector3(1000, 1000, 0);
        }

        if (player.ui.Lives == 1)
        {
            live1.localPosition = new Vector3(-365, 190, 0);

            live2.localPosition = new Vector3(1000, 1000, 0);

            live3.localPosition = new Vector3(1000, 1000, 0);

        }

        if (player.ui.Lives == 0)
        {
            live1.localPosition = new Vector3(1000, 1000, 0);

            live2.localPosition = new Vector3(1000, 1000, 0);

            live3.localPosition = new Vector3(1000, 1000, 0);

        }

    }
}
