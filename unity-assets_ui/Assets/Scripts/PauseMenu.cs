using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public UnityEvent<bool> ToggleMenu;
    public UnityEvent<bool> ToggleMenuInverted;

    private bool isPaused = false;

    public void OnEnable()
    {
        ToggleMenuInverted.Invoke(false);
        ToggleMenu.Invoke(true);
    }

    public void OnDisable()
    {
        ToggleMenuInverted.Invoke(true);
        ToggleMenu.Invoke(false);
    }

    public void MainMenu()
    {
        //OptionsMenu.lastScene = 0;
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        //OptionsMenu.lastScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f; // Pause the game by setting the time scale to 0.
        isPaused = true;
        gameObject.SetActive(true); // Show the PauseMenu canvas.
    }

    public void Resume()
    {
        Time.timeScale = 1f; // Resume the game by setting the time scale back to 1.
        isPaused = false;
        gameObject.SetActive(false); // Hide the PauseMenu canvas.
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause(); // Toggle pause when the Escape key is pressed.
        }
    }
}
