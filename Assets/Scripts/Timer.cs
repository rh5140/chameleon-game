// From https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] public float timeRemaining;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;

    public GameOverScreen GameOverScreen;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                Time.timeScale = 0;
                GameOver();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = "Time remaining: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void GameOver()
    {
        GameOverScreen.Setup();
    }
}