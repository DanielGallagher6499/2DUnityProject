using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerDeathSound, fireSound, EnemyDeathSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        //This is for adding the sounds which are located in the resources file
        playerDeathSound = Resources.Load<AudioClip>("playerDeath");
        fireSound = Resources.Load<AudioClip>("FireSound");
        EnemyDeathSound = Resources.Load<AudioClip>("enemyDeath");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        //Switch statement for the different sounds needed for the game
        switch (clip)
        {
            case "FireSound":
                audioSrc.PlayOneShot(fireSound);
                break;
            case "playerDeath":
                audioSrc.PlayOneShot(playerDeathSound);
                break;
            case "enemyDeath":
                audioSrc.PlayOneShot(EnemyDeathSound);
                break;
        }
    }
}
