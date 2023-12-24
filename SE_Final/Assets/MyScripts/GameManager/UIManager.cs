// I'm creating the UI game manager by followin the lecuter's instructions provided during Lecture 6.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GamneManager{
public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public GameObject pauseMenu;

    public voice UpdateScoreDisplay(int score) // I set up a score variable to show the score on the screen.
    {
        scoreText.text = "Score: " + score;
    }
   
   public voide TogglePauseMenu(bool isPaused)
   {
       pauseMenu.SetActive(isPaused);
   }
}
}