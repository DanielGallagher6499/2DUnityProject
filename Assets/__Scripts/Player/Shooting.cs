using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //Public Variables
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 45f;


    void Update()
    {
        //Shoot function
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //This makes the sound for shooting play when the player shoots
        SoundManager.PlaySound("FireSound");

        //Instantiates the bullet and adds force to it
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
