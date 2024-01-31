using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Inventory : MonoBehaviour {

    public TMP_Text infoText;

    public Dictionary<string, GundamRobot> inventory = new Dictionary<string, GundamRobot>();
    public int numFound;

    public void setNumFound(int numFound){
        //initialise all gundam
        this.numFound = numFound;
    }

    public void setInventory(Dictionary<string, GundamRobot> inventory){
        this.inventory = inventory;
    }

    public int getNumFound(){
        return numFound;
    }

    public List<GundamRobot> checkClose(){
        List<GundamRobot> closeList = new List<GundamRobot>();
        foreach (GundamRobot gundamRobot in inventory.Values){
            //checks how far gundam robot is from correct coordinates
            if (gundamRobot.isClose()){
                gundamRobot.setClose();
                closeList.Add(gundamRobot);
            }
        }
        return closeList;
    }

    public void addToInventory(string gundamRobotName){
        if (inventory.ContainsKey(gundamRobotName)){
            GundamRobot gundamRobot = inventory[gundamRobotName];
            gundamRobot.setFound();
            numFound+=1;
        }
        //inventory.Contains(gundamRobot.name, gundamRobot);
        //gundamRobot.setFound();
    }

    public void infoPageGundam(GundamRobot gundam){
        infoText.text = gundam.getInformation();
    }
}