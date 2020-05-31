using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;

    Rigidbody2D rb;
    float movement = 0f;
    public Text scoreText;
    private float topScore = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

        if (movement < 0)
        {

            this.GetComponent<SpriteRenderer>().flipX = false;

        }
        if (movement > 0)
        {

            this.GetComponent<SpriteRenderer>().flipX = true;

        }

        if (rb.velocity.y > 0 && transform.position.y > topScore)
        {

            topScore = transform.position.y;

        }

        scoreText.text = "Score: " + Mathf.Round(topScore * 12).ToString();

        if (transform.position.y < topScore - 8f)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("GameOver");
        }

    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
