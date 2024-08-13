using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pacman : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>();
        SetDirection(direction);
    }

    public void SetDirection(Vector2 direction)
    {
        if (direction == Vector2.up)
        {
            Debug.Log("Pacman is moving up");
        }
        else if (direction == Vector2.down)
        {
            Debug.Log("Pacman is moving down");
        }
        else if (direction == Vector2.left)
        {
            Debug.Log("Pacman is moving left");
        }
        else if (direction == Vector2.right)
        {
            Debug.Log("Pacman is moving right");
        }

    }
}
