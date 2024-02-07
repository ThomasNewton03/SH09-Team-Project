using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    void OnEnable(){

        setInventory(GameObject.FindGameObjectsWithTag("item"));

        foreach (GameObject item in inventory){
            item.GetComponent<Button>().interactable = item.GetComponent<GundamRobot>().getDiscovered();
        }

    }
    public void setNumFound(int numFound){
        //initialise all gundam
        this.numFound = numFound;
    }

    public void setInventory(GameObject[] inventory){
        this.inventory = inventory;
    }

    public int getNumFound(){
        return numFound;
    }

    // public void addToInventory(GundamRobot gundamRobot){
    //     inventory.Add(gundamRobot);
    // }

    public void infoPageGundam(GundamRobot gundam){
        infoText.text = gundam.getInformation();
        imageArea.GetComponent<Image>().sprite = gundam.getSprite();
    }

    public void quizPageGundam(GundamRobot gundam){
        quizQuestion.text = gundam.getQuizQuestion();
        string[] answers = gundam.getQuizAnswers();
        quizAnswer1.text = answers[0];
        quizAnswer2.text = answers[1];
        quizAnswer3.text = answers[2];
        quizAnswer4.text = answers[3];
        quizContainer.GetComponent<CheckAnswer>().correctIndex = gundam.getQuizCorrectIndex();
    }
}