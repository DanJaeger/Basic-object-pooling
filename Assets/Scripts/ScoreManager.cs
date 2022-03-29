using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text scoreText;
    public static int score = 0;

    void Start()
    {
        scoreText = GetComponent<Text>();   
    }

    void Update()
    {
        scoreText.text = "SCORE: " + score;
    }
}
