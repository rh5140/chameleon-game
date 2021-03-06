using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scorekeeper : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameEnd VictoryScreen;
    public AudioSource music;
    [SerializeField] public int total;

    private int score;
    private bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = true;
        score = 0;
        scoreText.text = score + " of " + total + " caught";
        music.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            if (score == total)
            {
                music.Stop();
                isPlaying = false;
                Victory();
            }
        }
        
    }

    public void UpdateScore(int scoreChange)
    {
        score += scoreChange;
        scoreText.text = score + " of " + total + " caught";
    }

    public void Victory()
    {
        VictoryScreen.Setup();
    }
}
