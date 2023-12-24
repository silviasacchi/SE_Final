// Creating the Game Mabnager script to tie all the game managers togghether. I'm following Lecture 6. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManager{
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score;

    [SerializeField] private UIManager uiManager; // Calling the UI manager script.

    private bool isPaused = false;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        ResetScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) // How to pause the game.
        {
            Togglepause();
        }
        if (Input.GetKeyDown(KeyCode.Escape)) // How to quit the game.
        {
            QuitGame();
        }
    }

    public void AddScore(int points)
    {
        score += points;
        uiManager.UpdateScoreText(score);
        AudioManager.Instance.PlaySoundEffect("PointScored"); // "PointScored" refers to the clip name.
    }

    public void ResetScore()
    {
        score = 0;
        uiManager.UpdateScoreText(score);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Togglepause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
            AudioManager.Instance.PlaySoundEffect("Pause"); // "Pause" refers to the clip name. 
        }
        else
        {
            Time.timeScale = 1;
            AudioManager.Instance.PlaySoundEffect("Unpause"); // "Unpause" refers to the clip name.
        }
        uiManager.TogglePauseMenu(isPaused);
    }
}
}