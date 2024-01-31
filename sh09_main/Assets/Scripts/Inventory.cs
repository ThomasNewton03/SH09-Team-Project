using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Inventory : MonoBehaviour {

    public TMP_Text infoText;
    public List<GundamRobot> inventory = new List<GundamRobot>();
    public int numFound;

    public void setNumFound(int numFound){
        //initialise all gundam
        this.numFound = numFound;
    }

    public void setInventory(List<GundamRobot> inventory){
        this.inventory = inventory;
    }

    public int getNumFound(){
        return numFound;
    }

    public void addToInventory(GundamRobot gundamRobot){
        inventory.Add(gundamRobot);
    }

    public void infoPageGundam(GundamRobot gundam){
        infoText.text = gundam.getInformation();
    }
}