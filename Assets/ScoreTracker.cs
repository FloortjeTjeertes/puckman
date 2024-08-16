using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
static class ScoreTracker:MonoBehaviour
{

    public Instance ScoreTracker;

    public void Awake()
    {
        if (ScoreTracker == null)
        {
            ScoreTracker = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    


    public static int score = 0;
    public static int highScore = 0;

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