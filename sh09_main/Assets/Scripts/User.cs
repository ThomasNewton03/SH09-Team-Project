/*
Things to create in this class:
- A function that stores the user's username
- A function that stores their password
- A function that stores the Gundam they have collected (inventory)
- A function that stores the user's level
- Test methods for each function
- The class should connect to inventory, settings, and game classes
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class user : MonoBehaviour {

    public string username;
    public int gundamCollected;
    public int quizCompleted;
    public TMP_Text gundamCollectedNumber;
    public TMP_Text quizCompletedNumber;
    public TMP_Text usernameText;
    public TMP_InputField inputUsernameField;

    void OnEnable(){
        //Update the number of gundam discovered and the number of quizzes completed every time you turn on the element
        gundamCollected = getGundamCount();
        quizCompleted = getQuizCompleted();
        Update();
    }

    void Update(){
        //update the username in the scene to the username stored in player prefs
        if(PlayerPrefs.HasKey("username")){
            username = PlayerPrefs.GetString("username", username);
            usernameText.text = username;
        }
        //update the number of gundam collected in the scene to the number of gundam collected stored in player prefs
        if (gundamCollectedNumber.text != gundamCollected.ToString()){
            gundamCollectedNumber.text = gundamCollected.ToString();
        }
        //update the number of quizzes completed in the scene to the number of quizzes completed stored in player prefs
        if (quizCompletedNumber.text != quizCompleted.ToString()){
            quizCompletedNumber.text = quizCompleted.ToString();
        }
    }

    public void UpdateUsername (){
        //check if the string is empty
        if (inputUsernameField.text.Length == 0){
            return;
        }
        //if its not empty then replace the stored username with the new one
        else {
            username = inputUsernameField.text;
            usernameText.text = username;
            PlayerPrefs.SetString("username", username);
        }
    }

    public int getGundamCount(){
        //get the number of gundam collected from player prefs
        return PlayerPrefs.GetInt("GundamCollected");
    }

    public int getQuizCompleted(){
        //get the number of quizzes completed from player prefs
        return PlayerPrefs.GetInt("QuizCompleted");
    }
}
