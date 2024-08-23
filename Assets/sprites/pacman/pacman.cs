using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pacman : MonoBehaviour
{
    private Vector2 currentDirection = Vector2.zero; // Store the current movement direction
    public float speed = 5.0f;
    public GameObject wall;

    public GameObject spawnPoint;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>();
        SetDirection(direction);
        // Debug.Log("Pacman is moving");
    }

    public void SetDirection(Vector2 direction)
    {

        checkForWall(direction);

        if (direction == Vector2.up)
        {
            // Debug.Log("Pacman is moving up");
            currentDirection = Vector2.up;
        }
        else if (direction == Vector2.down)
        {
            // Debug.Log("Pacman is moving down");
            currentDirection = Vector2.down;

        }
        else if (direction == Vector2.left)
        {
            // Debug.Log("Pacman is moving left");
            currentDirection = Vector2.left;
        }
        else if (direction == Vector2.right)
        {
            // Debug.Log("Pacman is moving right");
            currentDirection = Vector2.right;
        }
        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if(other.gameObject.CompareTag("wall"))
        {
            Debug.Log("Pacman hit a wall");
            StopMoving();
        }

        if (other.gameObject.CompareTag("pickup"))
        {
            Debug.Log("Pacman ate a pickup");
            checkPelletType(other.gameObject);
            // Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("enemy"))
        {
            checkForGhost(other.gameObject);
            // Destroy(gameObject);
        }
    }

   


    private bool checkForWall(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction);
        Debug.Log("Pacman hit a: " + hit.collider.gameObject.name);
        if(hit.collider.gameObject.CompareTag("wall"))
        {
            return true;
        }
        return false;
    }

    private void checkPelletType(GameObject pickup)
    {
    
        switch(pickup.name){
            case "PowerPellet":
                Debug.Log("Pacman ate a Powerpellet");
            break;
            case "Pellet":
                Debug.Log("Pacman ate a Pellet");
            break;
        }


    }

    private void checkForGhost(GameObject enemy)
    {
        Debug.Log("Pacman hit an enemy ghost");
        Ghost ghost = enemy.GetComponent<Ghost>(); 

        if(ghost.isVulnerable)
        {
            Debug.Log("Pacman ate a ghost");
        }
        else
        {
            Debug.Log("Pacman was eaten by a ghost");
            LiveTracker.LoseLife();
            Respawn();
        }
    }

    private void Respawn()
    {
        StopMoving();
        currentDirection = Vector2.zero;
    }
    private void Move()
    {
        if(!        checkForWall(currentDirection)){

        transform.Translate(currentDirection * speed * Time.deltaTime);
        }
    }

    private void StopMoving()
    {
        currentDirection = Vector2.zero;
    }

}
