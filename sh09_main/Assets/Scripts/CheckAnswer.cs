using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckAnswer : MonoBehaviour
{
    
    public int correctIndex;
    public TMP_Text answer;
    public GameObject correct;
    public GameObject incorrect;
    
    public void check(int currentIndex){
        correct.SetActive(false);
        incorrect.SetActive(false);
        if (correctIndex == currentIndex){
            answer.text = "You are correct";
            correct.SetActive(true);
        } else {
            answer.text = "You are incorrect";
            incorrect.SetActive(true);
        }
    }

}
