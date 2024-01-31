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
    public bool discovered = false;
    public string information;
    public DateTime timeDiscovered = DateTime.MinValue;
    public enum DisplayType {FOUND, CLOSE, NOTFOUND};
    public DisplayType displayType = DisplayType.NOTFOUND;
    //create coordinates for gundam- give a setter and getter

    public GundamRobot(int id, string gundamName, string location, Quiz quiz, string information){
        this.id = id;
        this.gundamName = gundamName;
        this.location = location;
        this.information = information;
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

    public void setFound(){
        this.displayType = DisplayType.FOUND;
    }

    public void setClose(){
        this.displayType = DisplayType.CLOSE;
    }

    public void setNotFound(){
        this.displayType = DisplayType.NOTFOUND;
    }

    public bool isFound(){
        return displayType == DisplayType.FOUND;
    }

    public bool isNotFound(){
        return displayType == DisplayType.NOTFOUND;
    }

    public bool isClose(){
        return displayType == DisplayType.CLOSE;
    }

}