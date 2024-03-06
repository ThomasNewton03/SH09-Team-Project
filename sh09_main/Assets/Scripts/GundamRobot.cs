using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GundamRobot : MonoBehaviour {
    public int id;
    public string gundamName;
    public string location;
    public string quizQuestion;
    public string[] quizAnswers = new string[4];
    public bool discovered;
    public string information;
    public DateTime timeDiscovered = DateTime.MinValue;
    [Range(1,4)]
    public int quizCorrectIndex;
    public Sprite gundamSprite;
    public Color32 quizCompleteColor; 
    public GameObject star;
    //create coordinates for gundam- give a setter and getter

    // public GundamRobot(int id, string gundamName, string location, Quiz quiz, string information){
    //     this.id = id;
    //     this.gundamName = gundamName;
    //     this.location = location;
    //     this.information = information;
    // }

    void Awake(){
        GetComponent<Image>().sprite = gundamSprite;
        if (!discovered){
            GetComponent<Button>().interactable = discovered;
        }
    }

    void OnEnable(){
        // image = GetComponent<Image>();
        if (PlayerPrefs.HasKey(quizQuestion)){
            // this.transform.parent.gameObject.GetComponent<Image>().color = quizCompleteColor;
            star.SetActive(true);
        } else{
            star.SetActive(false);
        }
    }


    public void setId(int id){
        this.id = id;
    }

    public int getId(){
        return id;
    }

    public void setGundamName(string gundamName){
        this.gundamName = gundamName;
    }

    public string getGundamName(){
        return gundamName;
    }

    public void setLocation(string location){
        this.location = location;
    }

    public string getLocation(){
        return location;
    }

    public void setDiscovered(bool discovered){
        if (discovered == true){
            PlayerPrefs.SetInt(this.getGundamName(), 1);
        } else {
            PlayerPrefs.SetInt(this.getGundamName(), 0);
        }
    }

    public bool getDiscovered(){
        return discovered;
    }

    public void setInformation(string information){
        this.information = information;
    }

    public string getInformation(){
        return information;
    }

    public void setQuizQuestion(string quizQuestion){
        this.quizQuestion = quizQuestion;
    }

    public string getQuizQuestion(){
        return quizQuestion;
    }

    public void setQuizAnswers(string[] quizAnswers){
        this.quizAnswers = quizAnswers;
    }

    public string[] getQuizAnswers(){
        return quizAnswers;
    }

    public void setTimeDiscovered(DateTime timeDiscovered){
        if (!discovered){
            this.timeDiscovered = timeDiscovered;
        }
    }

    public DateTime getTimeDiscovered(){
        if (discovered) {
            return timeDiscovered;
        }
        return DateTime.MinValue;
    }

    public void setQuizCorrectIndex(int index){
        this.quizCorrectIndex = index;
    }

    public int getQuizCorrectIndex(){
        return quizCorrectIndex;
    }

    public Sprite getSprite(){
        return gundamSprite;
    }

}