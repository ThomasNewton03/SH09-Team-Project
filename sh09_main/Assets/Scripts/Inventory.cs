using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Inventory : MonoBehaviour {

    public TMP_Text infoText;
    public TMP_Text quizQuestion;
    public TMP_Text quizAnswer1;
    public TMP_Text quizAnswer2;
    public TMP_Text quizAnswer3;
    public TMP_Text quizAnswer4;
    public List<GundamRobot> inventory = new List<GundamRobot>();
    public int numFound;

    public void setNumFound(int numFound){
        //initialise all gundam
        this.numFound = numFound;
    }

    public void setInventory(List<GundamRobot> inventory){
        this.inventory = inventory;
    }

    public int getNumFound(){
        return numFound;
    }

    public void addToInventory(GundamRobot gundamRobot){
        inventory.Add(gundamRobot);
    }

    public void infoPageGundam(GundamRobot gundam){
        infoText.text = gundam.getInformation();
    }

    public void quizPageGundam(GundamRobot gundam){
        quizQuestion.text = gundam.getQuizQuestion();
        string[] answers = gundam.getQuizAnswers();
        quizAnswer1.text = answers[0];
        quizAnswer2.text = answers[1];
        quizAnswer3.text = answers[2];
        quizAnswer4.text = answers[3];
    }
}