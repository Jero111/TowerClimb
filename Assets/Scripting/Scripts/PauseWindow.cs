using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseWindow : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject warningUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void MainMenu()
    {
        pauseMenuUI.SetActive(false);
        warningUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void WarnYes()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void WarnNo()
    {
        warningUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
