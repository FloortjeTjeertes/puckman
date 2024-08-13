using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ghost : MonoBehaviour
{

    public Grid grid;
    private GhostMode mode;
    private float baseSpeed;
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
     public abstract void SetTarget();


    
    // public  void Move(){

    // };


}
