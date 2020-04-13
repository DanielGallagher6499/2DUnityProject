using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private Transform player;
    private GameObject playerObject;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        //Move the enemy towards the object with the player tag
        playerObject = GameObject.Find("Player");
        player = playerObject.transform;
        rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D whatHitMe)
    {
        //param is collider comp of whatever hit me -
        //different behaviour required
        //could check the tag type for the object
        //could check for different components
        var player = whatHitMe.GetComponent<PlayerMovement>();
        var bullet = whatHitMe.GetComponent<Bullet>();

        if (player)//if player != null
        {
            //inflict damage on player?

            //destroy enemy
            //play when player is killed
            SoundManager.PlaySound("playerDeath");
            Destroy(player.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("DeathScreen");
        }

        if (bullet)//if player != null
        {
            //plays when enemy is shot
            SoundManager.PlaySound("enemyDeath");
            // GameObject explosion = Instantiate(explosionFX,
            //                                  transform.position,
            //                                  transform.rotation);
            // Destroy(explosion, explosionDuration);
            //Destroys bullet
            Destroy(bullet.gameObject);
            // PublishEnemyKilledEvent();
            //Destroys enemy
            Destroy(gameObject);
        }

    }
}
