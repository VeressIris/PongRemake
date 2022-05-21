using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private ScoreManager score;
    [SerializeField] private GameManager gameScript;
    [SerializeField] private AudioManager audioScript;

    private Rigidbody2D rb;

    private float speed = 4f;

    void Start()
    {
        gameObject.transform.position = new Vector2(0, 0);

        rb = GetComponent<Rigidbody2D>();

        LaunchBall();
    }

    public void LaunchBall()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(speed * x, speed * y);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        audioScript.PlaySound("hit");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (rb.position.x > 0)
        {
            score.player1Score++;
        }
        else
        {
            score.player2Score++;
        }

        audioScript.PlaySound("goal");
        gameScript.RestartGame();
    }
}
