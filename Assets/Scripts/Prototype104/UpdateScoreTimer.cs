using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdateScoreTimer : MonoBehaviour
{
    // variable for GameUIs
    private GameObject _gameUI;
    private GameObject _gameOverUI;

    // variables for score
    private Text scoreUI;
    public string scoreText = "Punktestand: ";
    private int currentScore = 0;
    public int addScore = 1;
    public int winScore = 5;

    // variables for timer
    private Text timerUI;
    public string timerText = "Countdown: ";
    public float countRemaining = 10f;
    private bool countingDown = true;

    // variables for result ui
    private Text resultUI;
    public string resultLost = "You lost!";
    public string resultWin = "You won!";

    // variables for game over
    public bool gameOver;
    private bool gameWon;
    private bool gameLost;


    void Start()
    {
        _gameUI = GameObject.Find("Game");
        _gameOverUI = GameObject.Find("GameOver");

        scoreUI = GameObject.Find("Score").GetComponent<Text>();
        timerUI = GameObject.Find("Timer").GetComponent<Text>();
        resultUI = GameObject.Find("Result").GetComponent<Text>();

        _gameUI.SetActive(true);
        _gameOverUI.SetActive(false);
    }

    void Update()
    {
        CountdownTimer();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            currentScore += addScore;
            scoreUI.text = scoreText + currentScore.ToString();            
        }

        if (gameOver)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                // Get inforamtion about active scene and load/reload this scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }


    private void CountdownTimer()
    {
        if(countingDown)
        {
            if(countRemaining > 0)
            {
                countRemaining -= Time.deltaTime;
                timerUI.text = timerText + Mathf.Round(countRemaining).ToString();
            }
            else 
            {
                countRemaining = 0;
                timerUI.text = timerText + countRemaining.ToString();
                countingDown = false;

                CheckGameOver();
            }
        }
    }



    private void CheckGameOver()
    {
        // GameOver WIN
        if(currentScore >= winScore)
        {
            gameWon = true;
            gameOver = true;

            resultUI.text = resultWin;
            resultUI.color = Color.green;
        }
        // GameOver LOST
        else if(currentScore < winScore && !countingDown)
        {
            gameLost = true;
            gameOver = true;

            resultUI.text = resultLost;
            resultUI.color = Color.red;
        }

        // Change the UI to display the GameOver screen
        if(gameOver)
        {
            _gameUI.SetActive(false);
            _gameOverUI.SetActive(true);
            
        }

    }


}