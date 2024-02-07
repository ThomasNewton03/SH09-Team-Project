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
        this.discovered = discovered;
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