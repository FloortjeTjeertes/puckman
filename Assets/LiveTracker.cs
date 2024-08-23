using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class LiveTracker:MonoBehaviour
{

    public LiveTracker Instance;

    private static int Lives = 3;

  

    public static int IntialLives = 3;

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
    

    public static int GetLives()
    {
        return Lives;
    }

    public static void ResetLives()
    {
        Lives = IntialLives;
    }

    public static void LoseLife()
    {
        Lives -= 1;
        ScoreTracker.ResetScore();
    }

}