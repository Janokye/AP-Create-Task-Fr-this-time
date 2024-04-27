using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Test");
    }

    public void OnClickHelp()
    {
        SceneManager.LoadScene("Help");
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
