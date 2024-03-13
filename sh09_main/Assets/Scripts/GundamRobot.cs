using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GundamRobot : MonoBehaviour {
    public int id;
    public string gundamName;
    public string quizQuestion;
    public string[] quizAnswers = new string[4];
    public bool discovered;
    public string information;
    [Range(1,4)]
    public int quizCorrectIndex;
    public Sprite gundamSprite;
    public Color32 quizCompleteColor; 
    public GameObject star;

    void Awake(){
        GetComponent<Image>().sprite = gundamSprite;
        //If the GUNDAM has not been discovered then make it uninteractable
        if (!discovered){
            GetComponent<Button>().interactable = discovered;
        }
    }

    void OnEnable(){
        //Check if quiz questions has been displayed correctlly and displays the star if it has
        if (PlayerPrefs.HasKey(quizQuestion)){
            star.SetActive(true);
        } else{
            star.SetActive(false);
        }
    }

    public string getGundamName(){
        return gundamName;
    }

    public string getInformation(){
        return information;
    }

    public string getQuizQuestion(){
        return quizQuestion;
    }

    public string[] getQuizAnswers(){
        return quizAnswers;
    }

    public int getQuizCorrectIndex(){
        return quizCorrectIndex;
    }

    public Sprite getSprite(){
        return gundamSprite;
    }

}