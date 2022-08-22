using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] Rigidbody2D arrowsRb;
    [SerializeField] Shoot shoot;
    private void Awake()
    {
        shoot = GameObject.Find("Player").GetComponent<Shoot>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }

    }

    private void Update()
    {
        if (shoot.isShoot)
        {
            StartCoroutine(DestroyArrow());
        }
    }


    IEnumerator DestroyArrow()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }







}
