using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    public float TimeBtwFire = 1f ;
    public  float bulletForce;
    private float timeBtwFire;
    
    void Update()
    {
        Gunning();
        timeBtwFire -= Time.deltaTime;
        if (Input.GetMouseButton(0) && timeBtwFire <0)
        {
            Fire();
        }
    }

     void Gunning()
    {
         Vector3 mousePos = Camera.main.ScreenToWorldPoint( Input.mousePosition );
        Vector2 lookDir = mousePos - transform.position;
        float angle = Mathf.Atan2( lookDir.y, lookDir.x ) *Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler( 0, 0, angle);
        transform.rotation = rotation;
        if (transform.eulerAngles.z > 90 && transform.eulerAngles.z <270)
        {
            transform.localScale = new Vector3((float)0.09, -(float)0.09, 0);
        }
        else
        {
            transform.localScale = new Vector3((float)0.09, (float)0.09, 0);
        }
    }
    void Fire()
    {
        timeBtwFire = TimeBtwFire;
        GameObject bulletTmp = Instantiate(bullet, firePos.position, Quaternion.identity);
        Rigidbody2D rb = bulletTmp.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletForce, ForceMode2D.Impulse);
    }
}
