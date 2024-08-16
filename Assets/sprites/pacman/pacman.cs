using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pacman : MonoBehaviour
{
    private Vector2 currentDirection = Vector2.zero; // Store the current movement direction
    public float speed = 5.0f;
    public GameObject wall;
    public List<GameObject> pickupTypes = new List<GameObject>();
    public List<GameObject> enemies = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        transform.Translate(currentDirection * speed * Time.deltaTime);

    }

    public void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>();
        SetDirection(direction);
        Debug.Log("Pacman is moving");
    }

    public void SetDirection(Vector2 direction)
    {
        if (direction == Vector2.up)
        {
            Debug.Log("Pacman is moving up");
            currentDirection = Vector2.up;
        }
        else if (direction == Vector2.down)
        {
            Debug.Log("Pacman is moving down");
            currentDirection = Vector2.down;

        }
        else if (direction == Vector2.left)
        {
            Debug.Log("Pacman is moving left");
            currentDirection = Vector2.left;
        }
        else if (direction == Vector2.right)
        {
            Debug.Log("Pacman is moving right");
            currentDirection = Vector2.right;
        }
        else
        {
            Debug.Log("Pacman is not moving");
            currentDirection = Vector2.zero;

            
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            checkForWall();
        }
        if (other.gameObject.CompareTag("pickup"))
        {
            Debug.Log("Pacman ate a pickup");
            // Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("enemy"))
        {
            Debug.Log("Pacman hit an enemy");
            // Destroy(gameObject);
        }
    }


    private void checkForPickupType()
    {
        foreach (GameObject pickup in pickupTypes)
        {
            if(GameObject.GetComponent<Fruit>){
                Debug.Log("Pacman ate a fruit" + pickup.name);
            }
            if(GameObject.GetComponent<Pellet>){
                Debug.Log("Pacman ate a pellet" + pickup.name);
            }
        }
    }


    //TODO: Check for wall maybe make generic so ghosts can use it
    private void checkForWall()
    {
        Debug.Log("Pacman hit a wall");
        SetDirection(Vector2.zero);
    }
}
