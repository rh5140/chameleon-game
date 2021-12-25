using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public void Setup()
    {
        Cursor.visible = true;
        gameObject.SetActive(true);
        Time.timeScale = 0;
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
