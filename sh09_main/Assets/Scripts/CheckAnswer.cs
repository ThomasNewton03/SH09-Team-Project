using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckAnswer : MonoBehaviour
{
    
    public int correctIndex;
    public TMP_Text question;
    public TMP_Text answer;
    public GameObject correct;
    public GameObject incorrect;

    public void check(int currentIndex){
        //Hide both the correct and incorrect GameObjects from the scene
        correct.SetActive(false);
        incorrect.SetActive(false);
        //Check if the selected answer matches the correct answer
        if (correctIndex == currentIndex){
            //Update the display text and show the correct GameObject
            answer.text = "You are correct";
            correct.SetActive(true);
            //Check if the player pref for the question exists
            if (!PlayerPrefs.HasKey(question.text))
            {
                //Set the player pref to indicate that the correct answer has been selected for this question
                PlayerPrefs.SetInt(question.text, 1);
                //Check if there is a number of quizzes completed value
                if (PlayerPrefs.HasKey("QuizCompleted") ) 
                {
                    //Add one to the number of quizzes completed
                    PlayerPrefs.SetInt("QuizCompleted", PlayerPrefs.GetInt("QuizCompleted") + 1);
                }else
                {
                    //Create the player prefs to store the number of quizzes completed
                    PlayerPrefs.SetInt("QuizCompleted", 1);
                }
            }
        } else {
            //Update the display text and show the incorrect GameObject
            answer.text = "You are incorrect";
            incorrect.SetActive(true);
        }
    }

    public void setCorrect(int index){
        correctIndex = index;
    }
}
