using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour {
    public static MainManager Instance;
    public GameObject settingsObject;
    Settings settings;
    private void Start()
    {
        //When you first load the app it should take you to the profile page
        if (!PlayerPrefs.HasKey("FirstLoad"))
        {
            settings.swapToProfilePage();
            PlayerPrefs.SetInt("FirstLoad", 1);
        }
    }

    private void Awake() 
    {
        settings = settingsObject.GetComponent<Settings>();
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        //Make sure that all GUNDAM are set to not show
        GameObject modelContainer = GameObject.Find("ModelContainer");
        foreach (Transform child in modelContainer.transform)
        {
            child.gameObject.SetActive(false);
        }
        
        //Load the users preferred settings and the correct page
        LoadSettings();
        LoadPage();
    } 

    [System.Serializable]
    class SaveData
    {
        public int fontSize;
    }

    public void SaveSettings()
    {
        //Save all the settings by calling the methods in settings
        settings.saveButtonSize(settings.getButtonSize());
        settings.saveFontSize(settings.getFontSize());
        settings.saveIsLeftHanded(settings.getIsLeftHanded() ? 1 : 0);
    }

    public void LoadSettings()
    {
        //Load all the settings by calling the methods in settings
        settings.loadButtonSize();
        settings.loadFontSize();
        settings.loadIsLeftHanded();
    }
    
    public void LoadPage()
    {
        //Check if there is a player pref for the last active page
        if (PlayerPrefs.HasKey("LastActivePage"))
        {
            //Use the function to go to the correct page
            string activePage = PlayerPrefs.GetString("LastActivePage");
            switch (activePage)
            {
                case "inventory":
                    settings.swapToInventoryPage();
                    break;
                case "profile":
                    settings.swapToProfilePage();
                    break;
                case "settings":
                    settings.swapToSettingsPage();
                    break;
                case "ar":
                    settings.swapToARPage();
                    break;
                
            }
        }
    }
    public void LoadMapScene()
    {
        //save the settings and set the last active page
        SaveSettings();
        PlayerPrefs.SetString("LastActivePage", settings.getActivePage());
        //loads the map scene
        SceneManager.LoadScene("Location-basedGame", LoadSceneMode.Single);
    }
}
