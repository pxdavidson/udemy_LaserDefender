using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    // Decalre variables
    int score;
    
    // Cache
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        IncreaseScore(0);
    }

    // Updates the score value
    public void IncreaseScore(int addScore)
    {
        score = score + addScore;
        scoreText.text = score.ToString();
    }
}
