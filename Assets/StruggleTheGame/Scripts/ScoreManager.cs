using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    //public Text scoreText;
    public Text goldscoreText;
    public Text highscoreText;
    

    //int score = 0;
    int goldscore = 0;
    int highscore = 0;
    

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        //scoreText.text = score.ToString();
        goldscoreText.text = goldscore.ToString();
        highscoreText.text = highscore.ToString();
        
    }

    /*void Update () //add score with time
    {
        scoreText.text = score.ToString();

        timer += (int)Time.deltaTime;

        if (timer > 2f)
        {
            score += 2;

            //change text when score change
            scoreText.text = score.ToString();

            //reset timer to 0
            timer = 0;
        }*/

    public void AddPoint() //add gold score
    {
        goldscore += 1;

        goldscoreText.text = goldscore.ToString();

        if(highscore < goldscore)
            PlayerPrefs.SetInt("highscore", goldscore);
    }
}
