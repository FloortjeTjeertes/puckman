using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ScoreTracker:MonoBehaviour
{

    public ScoreTracker Instance;

    public static int score = 0;
    public static int highScore = 0;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    


  

    public static void ResetScore()
    {
        score = 0;
    }

    public static void AddScore(int value)
    {
        score += value;
        if (score > highScore)
        {
            highScore = score;
        }
    }
}