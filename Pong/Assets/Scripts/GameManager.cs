using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player1Paddle;
    [SerializeField] private GameObject player2Paddle;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject pauseText;

    [SerializeField] private BallMovement ballScript;

    private const float XPOS = 8.45f;

    private bool isPaused;

    void Start()
    {
        pauseText.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void RestartGame()
    {
        player1Paddle.transform.position = new Vector3(-XPOS, 0, 0);
        player2Paddle.transform.position = new Vector3(XPOS, 0, 0);

        ball.transform.position = new Vector3(0, 0, 0);
        ballScript.LaunchBall();
    }

    void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0;
            pauseText.SetActive(true);
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            pauseText.SetActive(false);
            isPaused = false;
        }
    }
}
