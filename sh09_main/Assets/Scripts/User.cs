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
    

    public user(string username, string password){
        this.username = username;
        this.userPassword = password;
    }

    public int getLevel(){
        return userLevel;
    }

}
