using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenui : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}