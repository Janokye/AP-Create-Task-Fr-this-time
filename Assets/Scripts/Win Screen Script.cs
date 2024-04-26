using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class WinScreenScript : MonoBehaviour
{
    public GameManager gm;
    Scene scene;

    public TMP_Text finalScore;
    public TMP_Text finalTotalCorrect;
    public TMP_Text finalTotalWrong;
 

    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Win")
        {
           Debug.Log("You are in the win scene");
           Debug.Log(GameManager.finalScore);
           
           finalScore.text = GameManager.finalScore.ToString();
           finalTotalCorrect.text = GameManager.finalCorrectAnswers.ToString();
           finalTotalWrong.text = GameManager.finalWrongAnswers.ToString();

        }
    }
}
