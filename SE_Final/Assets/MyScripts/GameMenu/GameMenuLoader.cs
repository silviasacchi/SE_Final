// I'm creating a script to connect the manin menu UI to the level currently available. I'm following this tutorial: https://www.youtube.com/watch?v=XtVya93yAHg
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("SimpleNaturePack_Demo"); // This will load the main scene.
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("UIGameStart"); // This will load the menu scene.
    }
}

