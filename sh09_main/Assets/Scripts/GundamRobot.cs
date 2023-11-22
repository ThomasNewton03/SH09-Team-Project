using System;
using UnityEngine;
public class GundamRobot : MonoBehaviour{
    int id;
    string gundamName;
    string location;
    Quiz quiz;
    bool discovered;
    string information;
    DateTime timeDiscovered;

    public GundamRobot(int id, string name, string location, Quiz quiz, bool discovered, string information, DateTime timeDiscovered){
        this.id = id;
        this.name = name;
        this.location = location;
        this.quiz = quiz;
        this.discovered = discovered;
        this.information = information;
        this.timeDiscovered = timeDiscovered;
    }

    public void setId(int id){
        this.id = id;
    }

    public int getId(){
        return id;
    }

    public void setName(string name){
        this.name = name;
    }

    public string getName(){
        return name;
    }

    public void setLocation(string location){
        this.location = location;
    }

    public string getLocation(){
        return location;
    }

    public void setQuiz(Quiz quiz){
        this.quiz = quiz;
    }

    public Quiz GetQuiz(){
        return quiz;
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
        this.timeDiscovered = timeDiscovered;
    }

    public DateTime getTimeDiscovered(){
        return timeDiscovered;
    }

}