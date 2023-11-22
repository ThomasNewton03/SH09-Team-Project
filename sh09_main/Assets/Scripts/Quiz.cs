using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Quiz : MonoBehaviour{

    string question;
    List<string> options;
    int selectedIndex;
    int answerIndex;
    bool isAnswerCorrect;

    public Quiz(string question, List<string> options, int selectedIndex, int answerIndex, bool isAnswerCorrect){
        this.question = question;
        this.options = options;
        this.selectedIndex = selectedIndex;
        this.answerIndex = answerIndex;
        this.isAnswerCorrect = isAnswerCorrect;
    }

    public void setQuestion(string question){
        this.question = question;
    }

    public string getQuestion(){
        return question;
    }

    public void setOptions(List<string> options){
        this.options = options;
    }

    public List<string> getOptions(){
        return options;
    }

    public void setSelectedIndex(int selectedIndex){
        this.selectedIndex = selectedIndex;
    }

    public int getSelectedIndex(){
        return selectedIndex;
    }

    public void setAnswerIndex(int answerIndex){
        this.answerIndex = answerIndex;
    }

    public int getAnswerIndex(){
        return answerIndex;
    }

    public void setIsAnswerCorrect(bool isAnswerCorrect){
        this.isAnswerCorrect = isAnswerCorrect;
    }

    public bool getIsAnswerCorrect(){
        return isAnswerCorrect;
    }

}