using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float arrowSpeed = 2000f;
    public GameObject arrowPrefab;
    public Arrow arrowClass;
    public bool isShoot = false;
    Vector2 extraArrowVector;
    InputD id;


    private void Start()
    {
        arrowClass = GetComponentInChildren<Arrow>();
        id = GameObject.Find("LevelManager").GetComponent<InputD>();
    }

    private void Update()
    {

    }

    public virtual void ShootArrow(float direction, Vector3 playerVector)
    {
        if (!isShoot)
        {
            isShoot = true;
            
            StartCoroutine(ShootStartTime(direction, playerVector));


            StartCoroutine(ShootRes());
        }
        



    }

    IEnumerator ShootRes()
    {
        yield return new WaitForSeconds(0.5f);
        isShoot = false;
    }

    

    IEnumerator ShootStartTime(float direction, Vector3 playerVector)
    {
        yield return new WaitForSeconds(0.3f);
        GameObject arrow = Instantiate(arrowPrefab, playerVector, Quaternion.identity);
        arrow.transform.localScale = new Vector3(direction, 1, 1);
        Rigidbody2D rb = arrow.AddComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        rb.gravityScale = 0;
        rb.velocity = new Vector2(direction, 0) * Time.fixedDeltaTime * arrowSpeed;
    }




}
