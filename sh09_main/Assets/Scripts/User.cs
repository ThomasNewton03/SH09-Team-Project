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
    public string userPassword;
    public int gundamCollected;
    public int quizCompleted;
    public Settings settings;
    public Inventory inventory;
    public TMP_Text gundamCollectedNumber;
    public TMP_Text quizCompletedNumber;
    public TMP_Text usernameText;
    //public InputField inputUsernameField;
    public TMP_InputField inputUsernameField;

    public user(string username, string password){
        this.username = username;
        this.userPassword = password;
    }

    void OnEnable(){
        gundamCollected = getGundamCount();
        quizCompleted = getQuizCompleted();
        Update();
    }

    void Start() {
        usernameText.text = username;
    }

    void Update(){
        
        if(PlayerPrefs.HasKey("username")){
            username = PlayerPrefs.GetString("username", username);
            usernameText.text = username;
        }

        if (gundamCollectedNumber.text != gundamCollected.ToString()){
            gundamCollectedNumber.text = gundamCollected.ToString();
        }

        if (quizCompletedNumber.text != quizCompleted.ToString()){
            quizCompletedNumber.text = quizCompleted.ToString();
        }
    }

    public void UpdateUsername (){
        if (inputUsernameField.text.Length == 0){
            return;
        }
        else {
            username = inputUsernameField.text;
            usernameText.text = username;
            PlayerPrefs.SetString("username", username);
        }
    }


    // public void increaseGundamCount(){
    //     gundamCollected+=1;
    // }

    public int getGundamCount(){
        return PlayerPrefs.GetInt("GundamCollected");
    }

    public int getQuizCompleted(){
        return PlayerPrefs.GetInt("QuizCompleted");
    }

    public Settings loadSettings(){
        return settings;
    }

    public void setUsername(string username){
        this.username = username;
    }

    public string getUsername(){
        return username;
    }
    

    public void setPassword(string userPassword){
        this.userPassword = userPassword;
    }

    public string getPassword(){
        return userPassword;
    }

}
