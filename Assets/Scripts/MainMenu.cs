using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

    public void CreditsButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Credits");
    }
}
