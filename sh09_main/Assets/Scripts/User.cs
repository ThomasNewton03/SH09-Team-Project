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
    public Settings settings;
    public Inventory inventory;
    public TMP_Text gundamCollectedNumber;
    public TMP_Text usernameText;
    //public InputField inputUsernameField;
    public TMP_InputField inputUsernameField;

    public user(string username, string password){
        this.username = username;
        this.userPassword = password;
    }

    void Start() {
        gundamCollected = 0;
        usernameText.text = username;
    }

    void Update(){
        if (gundamCollectedNumber.text != gundamCollected.ToString()){
            gundamCollectedNumber.text = gundamCollected.ToString();
        }
        
        usernameText.text = username;
    
    }

    void UpdateUsername (){
        if (inputUsernameField.text == null){
            usernameText.text = username;
        }
        else {
            username = inputUsernameField.text;
            usernameText.text = username;
        }
    }

    public void increaseGundamCount(){
        gundamCollected+=1;
    }

    public int getGundamCount(){
        return gundamCollected;
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
