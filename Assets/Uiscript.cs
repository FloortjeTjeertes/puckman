using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Uiscript : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        score = ScoreTracker.score;

        if(scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }

        highScore = ScoreTracker.highScore;
        if (highScoreText != null)
        {
            highScoreText.text = "High Score: " + highScore;
        }
    }

  
}
