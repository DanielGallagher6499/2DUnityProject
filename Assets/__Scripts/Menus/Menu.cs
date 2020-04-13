using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Added to allow scene managment
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Method loads the next scene in the build index once the play button is pressed.
    public void PlayGame()
    {
        //Loads scenes
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Resets the game score to 0 
        Score.scoreValue = 0;
    }

    // Method quits the game once quit button is clicked. Cannot be seen unless built or looking in console.
    public void QuitGame()
    {
        //Debug to show quit game is working 
        Debug.Log("Quit Game!");
        Application.Quit();
    }

    // Method loads the menu when you chnage to it from death screen.
    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}


