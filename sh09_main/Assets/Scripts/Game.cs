using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game : MonoBehaviour {


    Inventory inventory;
    

    public void addGundamOnDiscovery(string gundamRobot){
        inventory.addToInventory(gundamRobot);
    }

}