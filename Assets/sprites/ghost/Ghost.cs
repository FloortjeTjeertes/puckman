using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ghost : MonoBehaviour
{

    public Grid grid;
    private GhostMode mode;
    private float baseSpeed;

    public bool isVulnerable;
    // private Tile selectedTile;


    public void SetMode(GhostMode newMode)
    {
        mode = newMode;
    }

    public GhostMode GetMode()
    {
        return mode;
    }

    public void SetBaseSpeed(float newSpeed)
    {
        baseSpeed = newSpeed;
    }

    // public  void Move(){

    // };
     public abstract void SetTarget();


    



}
