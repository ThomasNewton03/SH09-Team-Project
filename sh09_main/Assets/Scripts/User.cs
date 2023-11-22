/*
Things to create in this class:
- A function that stores the user's username
- A function that stores their password
- A function that stores the Gundam they have collected (inventory)
- A function that stores the user's level
- Test methods for each function
- The class should connect to inventory, settings, and game classes
*/
using UnityEngine;

public class user : MonoBehaviour{

    string username;
    string userPassword;
    int userLevel = 1;
    Settings settings;
    Inventory inventory;
    

    public user(string username, string password){
        this.username = username;
        this.userPassword = password;
    }

    public void increaseLevel(){
        userLevel+=1;
    }

    public int getLevel(){
        return userLevel;
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
