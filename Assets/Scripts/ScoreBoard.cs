using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    int score;
    TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Start";
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void UpdateScore (int increment) {
        score += increment;
        // Debug.Log("Score is " + score);
        scoreText.text = score.ToString();
    }
}
