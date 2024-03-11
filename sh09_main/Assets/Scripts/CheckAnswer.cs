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
        correct.SetActive(false);
        incorrect.SetActive(false);
        if (correctIndex == currentIndex){
            answer.text = "You are correct";
            correct.SetActive(true);
            if (!PlayerPrefs.HasKey(question.text))
            {
                PlayerPrefs.SetInt(question.text, 1);
                if (PlayerPrefs.HasKey("QuizCompleted") ) 
                {
                    PlayerPrefs.SetInt("QuizCompleted", PlayerPrefs.GetInt("QuizCompleted") + 1);
                }else
                {
                    PlayerPrefs.SetInt("QuizCompleted", 1);
                }
            }
        } else {
            answer.text = "You are incorrect";
            incorrect.SetActive(true);
        }
    }

    public void setCorrect(int index){
        correctIndex = index;
    }
}
