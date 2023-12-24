// I'm creating the UI game manager by followin the lecuter's instructions provided during Lecture 6.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GameManager{
public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public GameObject pauseMenu;

    public void UpdateScoreText(int score) // I set up a score variable to show the score on the screen.
    {
        scoreText.text = "Score: " + score;
    }
   
   public void TogglePauseMenu(bool isPaused)
   {
       pauseMenu.SetActive(isPaused);
   }
}
}