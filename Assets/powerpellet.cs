using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerpellet : MonoBehaviour
{
    public bool isPowerPellet = false;

    private Sprite defaultSprite; // Assign in the editor
    private Sprite powerPelletSprite; // Assign in the editor

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (isPowerPellet)
            {
              Debug.Log("Power Pellet Eaten");
              ScoreTracker.AddScore(50);
            }
            else
            {
              Debug.Log("Pellet Eaten");
              ScoreTracker.AddScore(10);
            }
            this.gameObject.SetActive(false);

        }
    }

    private ChangeSprite()
    {
        if (isPowerPellet && powerPelletSprite != null)
        {
            spriteRenderer.sprite = powerPelletSprite;
        }
        else if (defaultSprite != null)
        {
            spriteRenderer.sprite = defaultSprite;
        }
    }
}
