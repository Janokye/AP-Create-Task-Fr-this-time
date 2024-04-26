
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
     public TMP_Text playerScoreTxt;
     public TMP_Text totalAnswersCorrectTxt;
     public TMP_Text totalAnswersWrongTxt;
     public TMP_Text num1Txt;
     public TMP_Text num2Txt;
     public TMP_Text playerFeedback;
     
     string playerInput;

     bool isAnswerSubmitted;

     int correctProduct;
     int numberOfCorrectAnswers;
     int numberofWrongAnswers;
     int numberOfQuestionsGenerated;
     int score;

     public static int finalScore;
     public static int finalCorrectAnswers;
     public static int finalWrongAnswers;

     public List<int> gameResults = new List<int>();

     void Start()
     {
         isAnswerSubmitted = false;
         GenerateQuestion();
     } 

     void Update()
     {
         
         if(numberOfQuestionsGenerated == 11)
         {
            
             
             CurrectGameResults();
             
             SceneManager.LoadScene("Win");
         }
     }
     
     void GenerateQuestion() 
     {

           int randNum1 = Random.Range(1,13); 
           int randNum2 = Random.Range(1,13);

           num1Txt.text = randNum1.ToString();
           num2Txt.text = randNum2.ToString();
           correctProduct = randNum1 * randNum2;       
     }

     public void SubmitAnswer(string input) 
     {

           isAnswerSubmitted = true;
           playerInput = input;
           CheckAnswer();
           numberOfQuestionsGenerated++;
     }

     void CheckAnswer()
     {
       int playerInputAsInt = int.Parse(playerInput); 

       if(playerInputAsInt != correctProduct)
       {
               numberofWrongAnswers += 1;
               score -= 3;
               totalAnswersWrongTxt.text = numberofWrongAnswers.ToString();
               playerFeedback.text = "WRONG!";

               StartCoroutine(FeedbackToTitleQuestion());
       }
       if(playerInputAsInt == correctProduct)
       {
               numberOfCorrectAnswers += 1;
               score++;
               totalAnswersCorrectTxt.text = numberOfCorrectAnswers.ToString();   
               
               
               for(int i = 1; i <= numberOfCorrectAnswers / 3; i++)
               {
                       score*= 2;      
               }    
               playerFeedback.text = "CORRECT!";
               StartCoroutine(FeedbackToTitleQuestion());
       }
       playerScoreTxt.text = score.ToString();
       numberOfQuestionsGenerated = numberOfCorrectAnswers + numberofWrongAnswers;
       GenerateQuestion();
     }

    public void CurrectGameResults()
    {
        gameResults.Add(score);
        gameResults.Add(numberOfCorrectAnswers);
        gameResults.Add(numberofWrongAnswers);

        finalScore = gameResults[0];
        finalCorrectAnswers = gameResults[1];
        finalWrongAnswers = gameResults[2];
    }

    IEnumerator FeedbackToTitleQuestion()
    {
       if(isAnswerSubmitted)
       {
          yield return new WaitForSeconds(1.2f);
          playerFeedback.text = "What is";
       }
    }
}
