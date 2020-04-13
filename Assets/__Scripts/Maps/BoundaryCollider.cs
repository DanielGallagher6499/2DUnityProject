using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BoundaryCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Function that destorys the bullet when it collides with boundary
        var bullet = collision.GetComponent<Bullet>();
        if (bullet)
        {
            Destroy(bullet.gameObject);
        }
    }
}
