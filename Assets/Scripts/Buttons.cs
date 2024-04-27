using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    GameManager gm;

    public static string gameMode;

    public void OnClickStart()
    {
        SceneManager.LoadScene("Set Difficulty");
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

   public void GameModeEasy()
   {
         gameMode = "Easy";
         SceneManager.LoadScene("Test");
   }
   public void GameModeMedium()
   {
         gameMode = "Medium";
         SceneManager.LoadScene("Test");
   }
   public void GameModeHard()
   {
         gameMode = "Hard";
         SceneManager.LoadScene("Test");
   }
}
