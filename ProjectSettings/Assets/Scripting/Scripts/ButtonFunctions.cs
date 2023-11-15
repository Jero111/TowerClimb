using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void LevelsScreen()
    {
        SceneManager.LoadScene("LvlScreen");
    }

    public void Settings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
