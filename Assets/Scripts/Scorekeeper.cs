using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scorekeeper : MonoBehaviour
{
    private int score;
    private int total;
    public TextMeshProUGUI scoreText;

    public VictoryScreen VictoryScreen;

    // Start is called before the first frame update
    void Start()
    {
        total = 10;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (score == total)
        {
            Victory();
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
