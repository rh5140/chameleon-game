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

    // Start is called before the first frame update
    void Start()
    {
        total = 10;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int scoreChange)
    {
        score += scoreChange;
        scoreText.text = score + " of " + total + " left to catch";
    }
}
