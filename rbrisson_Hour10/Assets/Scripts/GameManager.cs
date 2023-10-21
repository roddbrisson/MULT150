using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    private bool isGameOver = true;

    public Transform spawnPoint;
    public GameObject player;

    private bool isRunning = false;
    private bool isFinished = false;

    private FirstPersonController fpsController;

    // Start is called before the first frame update
    void Start()
    {
        Physics.autoSyncTransforms = true;

        // Finds the First Person Controller script on the Player
        fpsController = player.GetComponent<FirstPersonController>();

        // Disables controls at the start.
        fpsController.enabled = false;
    }

    private void StartGame()
    {
        isRunning = true;
        isFinished = false;

        // Move the player to the spawn point, and allow it to move.
        PositionPlayer();
        fpsController.enabled = true;
    }

    public void FinishedGame()
    {
        isRunning = false;
        isFinished = true;
        fpsController.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
    }

    public void PositionPlayer()
    {
        player.transform.position = spawnPoint.position;
        player.transform.rotation = spawnPoint.rotation;
    }
    void OnGUI()
    {
        if (!isRunning)
        {
            string message;

            if (isFinished)
            {
                message = "Click or Press Enter to Play Again";
            }
            else
            {
                message = "Click or Press Enter to Play";
            }

            //Define a new rectangle for the UI on the screen
            Rect startButton = new Rect(Screen.width / 2 - 120, Screen.height / 2, 240, 30);

            if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
            {
                //start the game if the user clicks to play
                StartGame();
            }
        }

        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
        }
    }
}
