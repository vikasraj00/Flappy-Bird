using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    int highScore;
    public Text panelScoreText;
    public Text panelHighScoreText;
    void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("highscore"); 
    }

    void Update()
    {
        GetComponent<Text>().text = score.ToString();
        panelScoreText.text = score.ToString();
        panelHighScoreText.text = highScore.ToString();

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highscore", highScore);
        }
    }
}
