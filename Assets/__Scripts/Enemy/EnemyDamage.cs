using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
    //public variables
    public int health = 1;
    public int score;
    public GameObject blood;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            KillEnemy();
        }
    }

    void KillEnemy()
    {
        //plays blood splatter when the enemy is killed 
        Instantiate(blood, transform.position, Quaternion.identity);
        //Adds scores when players killed
        Score.scoreValue += 5;
        score = Score.scoreValue;
        Destroy(gameObject);
        //If statement to change scenes
        if (score == 100)
        {
            //If player reaches 100 points -> Level 2
            Debug.Log("Level 2 Started");
            SceneManager.LoadScene("Level2");
        }
        if (score == 200)
        {
            //If player reaches 200 points -> Level 3
            SceneManager.LoadScene("Level3");
        }
        if (score == 500)
        {
            //If player reaches 500 points -> Winner
            SceneManager.LoadScene("WinnerScene");
        }
    }

}