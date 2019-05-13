using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UXShepherd : MonoBehaviour
{
    // Declare variables
    [SerializeField] float deathDelay = 3f;

    // Starts the game if LCtrl is pressed
    private void StartGame()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            // Do nothing
        }
    }
        
    // Quit game with ESC
    private void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else
        {
            // Do nothing
        }
    }

    // Load Game Over screen
    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }

    // Waits for specified time then loads Game Over
    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(deathDelay);
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        StartGame();
    }
}
