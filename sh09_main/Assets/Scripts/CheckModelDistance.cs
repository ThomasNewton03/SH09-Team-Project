using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class CheckModelDistance : MonoBehaviour
{

    private GameObject Player;
    private Vector3 PlayerPosition;
    private float closeEnough;
    public GameObject button;
    public MapManager mapManager;

    // // Start is called before the first frame update
    void Start()
    {
        // Get the Player object on the map and add call to the ButtonClicked function on button click to the map button
        Player = GameObject.FindGameObjectWithTag("Player");
        button.GetComponent<Button>().onClick.AddListener(delegate () { this.ButtonClicked(); });
        closeEnough = 20;
    }

    // Update is called once per frame
    void Update()
    {
        // Get position of player marker and this models position in unity space
        PlayerPosition = Player.transform.position;
        float distance = Vector3.Distance(PlayerPosition, this.transform.position);

        if (distance < closeEnough)
        {
            button.SetActive(true);
        }else
        {
            button.SetActive(false);
        }
    }

    // Method called when collect button clicked
    void ButtonClicked()
    {
        // Set state of where you have been in the app and format the model name correctly
        PlayerPrefs.SetString("LastActivePage", "ar");
        string name = this.name.Replace("(Clone)", "");
        PlayerPrefs.SetString("TargetModel", name);
        // If model hasn't been found already...
        if (PlayerPrefs.GetInt(name) != 1)
        {
            // ...set found
            PlayerPrefs.SetInt(name, 1);
            // Update count of how many models found
            if (PlayerPrefs.HasKey("GundamCollected") ) 
            {
                PlayerPrefs.SetInt("GundamCollected", PlayerPrefs.GetInt("GundamCollected") + 1);
            }else
            {
                PlayerPrefs.SetInt("GundamCollected", 1);
            }
        }
        
        // Move from map to AR scene
        mapManager.LoadAppScene();
    }

    public void setDistance(float distance){
        closeEnough = distance;
    }
}
