using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

    public void ExitButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }
}
