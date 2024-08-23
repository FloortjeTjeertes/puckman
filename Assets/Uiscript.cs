using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Uiscript : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;

    public int lives = 3;

    public int baseLives = 3;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public TextMeshProUGUI livesText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        score = ScoreTracker.GetScore();

        if(scoreText != null)
        {
            scoreText.text = "Score: " + ScoreTracker.GetScore();
        }

        highScore = ScoreTracker.GetHighScore();
        if (highScoreText != null)
        {
            highScoreText.text = "High Score: " + highScore;
        }

        lives = LiveTracker.GetLives();
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }

    }

    
  
}
