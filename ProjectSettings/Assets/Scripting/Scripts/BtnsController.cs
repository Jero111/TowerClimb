using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnsController : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Nivel2");
    }
}
