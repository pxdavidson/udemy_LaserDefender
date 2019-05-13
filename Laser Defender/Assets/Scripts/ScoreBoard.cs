﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    // Declare variables
    int score = 0;
    
    // Cache
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    // Updates the score value
    public void IncreaseScore(int scoreAddition)
    {
        score = score + scoreAddition;
    }
}
