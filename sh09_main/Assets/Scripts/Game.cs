using UnityEngine;
public class Game : MonoBehaviour{


    Inventory inventory;
    

    public void addGundamOnDiscovery(string gundamRobot){
        inventory.addToInventory(gundamRobot);
    }

}