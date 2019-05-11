using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UXShepherd : MonoBehaviour
{
    
    // Starts the game if LCtrl is pressed
    private void StartGame()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
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

    // Update is called once per frame
    void Update()
    {
        StartGame();
    }
}
