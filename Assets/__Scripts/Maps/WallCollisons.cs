using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollisons : MonoBehaviour
{

    private void OnCollisionEnter2D (Collision2D collision)
    {

       var bullet = collision.collider.GetComponent<Bullet>();
       if (bullet)
        {
           Destroy(bullet.gameObject);
        }
        print(collision);
    }
}
