using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
public class Inventory : MonoBehaviour {

    public TMP_Text infoText;
    public GameObject imageArea;
    public TMP_Text quizQuestion;
    public TMP_Text quizAnswer1;
    public TMP_Text quizAnswer2;
    public TMP_Text quizAnswer3;
    public TMP_Text quizAnswer4;
    public GameObject quizContainer;
    public GameObject[] inventory;
    public int numFound;
    public Color32 quizCompleteColor; 

    void Update(){
        //Get all GUNDAM and add it to the inventory
        setInventory(GameObject.FindGameObjectsWithTag("item"));
        foreach (GameObject item in inventory){
            String gundamName = item.GetComponent<GundamRobot>().getGundamName();
            Button button = item.GetComponent<Button>();
            if (PlayerPrefs.HasKey(gundamName)){
                //Check if the Gundam has been discovered and set it to that boolean value
                button.interactable = Convert.ToBoolean(PlayerPrefs.GetInt(gundamName));
            } else {
                button.interactable = false;
            }
        }
    }

    public void setInventory(GameObject[] inventory){
        this.inventory = inventory;
    }

    public void infoPageGundam(GundamRobot gundam){
        //Set the text in the information page to the correct information
        infoText.text = gundam.getInformation();
        //Set the image in the information page to the correct image
        imageArea.GetComponent<Image>().sprite = gundam.getSprite();
    }

    public void quizPageGundam(GundamRobot gundam){
        //Set the quiz question in the quiz page to the correct question
        quizQuestion.text = gundam.getQuizQuestion();
        //Set the quiz answers in the quiz page to the correct options
        string[] answers = gundam.getQuizAnswers();
        quizAnswer1.text = answers[0];
        quizAnswer2.text = answers[1];
        quizAnswer3.text = answers[2];
        quizAnswer4.text = answers[3];
        //Set correct index to the correct index for the GUNDAM
        quizContainer.GetComponent<CheckAnswer>().setCorrect(gundam.getQuizCorrectIndex());
    }
}