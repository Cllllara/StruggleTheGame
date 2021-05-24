using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{


    public void PlayGame()
    {
        SceneManager.LoadScene("StruggleTheGame");
    }

    public void HelpMenu()
    {
        SceneManager.LoadScene("HelpMenu");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
