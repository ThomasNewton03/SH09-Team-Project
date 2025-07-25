using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
public class Settings : MonoBehaviour {

    public Slider buttonSizeSlider;
    public Slider fontSizeSlider;
    public Toggle leftHandToggle;
    public GameObject menuLeftHand;
    public GameObject menuRightHand;
    public GameObject mapRightHand;
    public GameObject mapLeftHand;
    public GameObject extendedButtonsRightHand;
    public GameObject extendedButtonsLeftHand;
    public GameObject infoExitRightHand;
    public GameObject infoExitLeftHand;
    public GameObject InfoPage;
    public GameObject InventoryPage;
    public GameObject ProfilePage;
    public GameObject SettingsPage;
    public GameObject Tutorial;
    public ARSession Session;
    public TMP_Text TutorialText;
    public List<GameObject> buttonList;
    private string activePage;
    private string tutorialInventory = "Here is your inventory, you can see all gundams greyed out and when you collect them they become interactable and show you information.";
    private string tutorialProfile = "Here is your profile, you can change you name and see the numbers of gundam you collected.";
    private string tutorialSettings = "Here is your settings, you can modify font and button size and if youre left handed or not. You can also request tutorial to play again.";
    private string tutorialInfo = "Here you can view information about the gundam and at the end attempt a quiz";
    private string tutorialAR = "Here you can view the gundams in the real world";
    public GameObject arPointer;
    public GameObject modelContainer;
    public GameObject collectButton;

    //toggleLeftHanded() is used in the toggle option, it will set leftHanded bool to true or false, and then set the menu and map buttons to right/left.
    public void toggleLeftHanded()
    {
        if (!InfoPage.active){
            setIsLeftHanded(leftHandToggle.isOn);
            menuLeftHand.SetActive(leftHandToggle.isOn);
            menuRightHand.SetActive(!leftHandToggle.isOn);
            mapLeftHand.SetActive(leftHandToggle.isOn);
            mapRightHand.SetActive(!leftHandToggle.isOn);
        }
    }

    //changeButtonSize() changes all the button sizes but using scale. All buttons are assumed to be on scale of 1,1,1. 
    //if a new button is added please keep scale at 1,1,1 for this to work
    public void changeButtonSize()
    {
        Vector3 additionScaleVector = Vector3.one;
        for (int i = 0; i < buttonList.Count; i++)
        {
            buttonList[i].transform.localScale = additionScaleVector + (additionScaleVector * buttonSizeSlider.value);
        }

    }

    //checkMapSide() is there to be used as a check for which side map should be at and sets it active.
    public void checkMapSide()
    {
        mapLeftHand.SetActive(leftHandToggle.isOn);
        mapRightHand.SetActive(!leftHandToggle.isOn);
    }

    //checkMenuSide() is there to be used as a check for which side menu button should be at and sets it as active.
    public void checkMenuSide()
    {
        menuLeftHand.SetActive(leftHandToggle.isOn);
        menuRightHand.SetActive(!leftHandToggle.isOn);
    }

    //checkInfoExitSide() is there to be used a check for which side the info exit button should be at and sets it as active.
    public void checkInfoExitSide()
    {
        infoExitLeftHand.SetActive(leftHandToggle.isOn);
        infoExitRightHand.SetActive(!leftHandToggle.isOn);
    }
    
    //UICheck() is going to be used to check sides of main ui (Map and menu)
    public void UICheck()
    {
        checkMapSide();
        checkMenuSide();
    }

    //closeUI() will close main ui buttons (menu buttons and map button)
    public void closeUI()
    {
        extendedButtonsLeftHand.SetActive(false);
        extendedButtonsRightHand.SetActive(false);
        menuLeftHand.SetActive(false);
        menuRightHand.SetActive(false);
        mapLeftHand.SetActive(false);
        mapRightHand.SetActive(false);
    }

    //these 4 swap buttons just swap to the page listed.
    public void swapToInfoPage()
    {
        checkInfoExitSide();
        TutorialText.text = tutorialInfo;
        InfoPage.SetActive(true);
        InventoryPage.SetActive(false);
        ProfilePage.SetActive(false);
        SettingsPage.SetActive(false);
        closeUI();
        setActivePage("info");
        tutorialCheck();
    }
    public void swapToInventoryPage()
    {
        UICheck();
        TutorialText.text = tutorialInventory;
        InfoPage.SetActive(false);
        InventoryPage.SetActive(true);
        ProfilePage.SetActive(false);
        SettingsPage.SetActive(false);
        closeAR();
        setActivePage("inventory");
        tutorialCheck();
    }
    public void swapToProfilePage()
    {
        UICheck();
        TutorialText.text = tutorialProfile;
        InfoPage.SetActive(false);
        InventoryPage.SetActive(false);
        ProfilePage.SetActive(true);
        SettingsPage.SetActive(false);
        closeAR();
        setActivePage("profile");
        tutorialCheck();
    }
    public void swapToSettingsPage()
    {
        UICheck();
        TutorialText.text = tutorialSettings;
        InfoPage.SetActive(false);
        InventoryPage.SetActive(false);
        ProfilePage.SetActive(false);
        SettingsPage.SetActive(true);
        closeAR();
        setActivePage("settings");
        tutorialCheck();
    }

    public void swapToARPage()
    {
        UICheck();
        TutorialText.text = tutorialAR;
        InfoPage.SetActive(false);
        InventoryPage.SetActive(false);
        ProfilePage.SetActive(false);
        SettingsPage.SetActive(false);
        collectButton.SetActive(true);
        openAR();
        closeUI();
        checkARModel();
        setActivePage("ar");
        tutorialCheck();
    }
    public void setButtonSize(float buttonSize){
        this.buttonSizeSlider.value = buttonSize;
    }

    public float getButtonSize(){
        return buttonSizeSlider.value;
    }

    public void setFontSize(float fontSize){
        this.fontSizeSlider.value = fontSize;
    }

    public float getFontSize(){
        return fontSizeSlider.value;
    }

    public void setIsLeftHanded(bool isLeftHanded){
        this.leftHandToggle.isOn = isLeftHanded;
    }

    public bool getIsLeftHanded(){
        return leftHandToggle.isOn;
    }

    //Save the button size player pref
    public void saveButtonSize(float saveButtonSize)
    {
        PlayerPrefs.SetFloat("buttonSizeScalar", saveButtonSize);
    }

    //Load the button size player pref
    public void loadButtonSize()
    {
        if (PlayerPrefs.HasKey("buttonSizeScalar")){
           setButtonSize(PlayerPrefs.GetFloat("buttonSizeScalar"));
           changeButtonSize();
        }else{
            //default button size
            setButtonSize((float)0.125);
        }
    }

    //Save the font size player pref
    public void saveFontSize(float saveFontSize)
    {
        PlayerPrefs.SetFloat("fontSizeScalar", saveFontSize);
    }

    //Load the font size player pref
    public void loadFontSize()
    {
        if (PlayerPrefs.HasKey("fontSizeScalar")){
           setFontSize(PlayerPrefs.GetFloat("fontSizeScalar"));
        }else{
            setFontSize((float)1.3);
        }
    }

    //Save the left handed player pref
    public void saveIsLeftHanded(int saveIsLeftHanded){
        PlayerPrefs.SetInt("isLeftHanded", saveIsLeftHanded);
    }

    //Load the left handed player pref
    public void loadIsLeftHanded(){
        if (PlayerPrefs.HasKey("isLeftHanded")){
           setIsLeftHanded(PlayerPrefs.GetInt("isLeftHanded") == 1 ? true : false);
        }else{
            setIsLeftHanded(false);
        }
    }

    public Slider getFontSizeSlider(){
        return fontSizeSlider;
    }
    
    public string getActivePage()
    {
        return activePage;
    }
    public void setActivePage(string page)
    {
        activePage= page;
    }

    //Uses closes AR session, so its not enabled while not in that page.
    public void closeAR()
    {
        collectButton.SetActive(false);
        Session.enabled = false;
        arPointer.SetActive(false);
        for(int i = 0; i < modelContainer.transform.childCount; ++i) {
            modelContainer.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    //open the AR session
    public void openAR()
    {
        Session.enabled = true;
        arPointer.SetActive(true);
    }

    //check which model you are going to display depending on what the target model player pref is
    public void checkARModel()
    {
        if (PlayerPrefs.HasKey("TargetModel"))
        {
            string activeModel = PlayerPrefs.GetString("TargetModel");
            GameObject model = modelContainer.transform.Find(activeModel).gameObject;
            if (model)
            {
                model.SetActive(true);
            }
        }
    }

    public void tutorialCheck()
    {
        //check if the player has already seen the tutorials
        if(!PlayerPrefs.HasKey(activePage) || PlayerPrefs.GetInt(activePage) == 0)
        {
            //check which page you are on
            switch (activePage)
            {
                case "inventory":
                    TutorialText.text = tutorialInventory;
                    break;
                case "profile":
                    TutorialText.text = tutorialProfile;
                    break;
                case "info":
                    TutorialText.text = tutorialInfo;
                    break;
                case "settings":
                    TutorialText.text = tutorialSettings;
                    break;
                case "ar":
                    TutorialText.text = tutorialAR;
                    break;
            }
            Tutorial.SetActive(true);
        }
        else
        {
            Tutorial.SetActive(false);
        }
    }

    //clear the tutorial for the page
    public void tutorialDone()
    {
        PlayerPrefs.SetInt(activePage, 1);
        Tutorial.SetActive(false);
    }

    //reset the tutorials so that they show again
    public void resetTutorial()
    {
        PlayerPrefs.SetInt("settings", 0);
        PlayerPrefs.SetInt("info", 0);
        PlayerPrefs.SetInt("profile", 0);
        PlayerPrefs.SetInt("ar", 0);
        PlayerPrefs.SetInt("inventory", 0);
    }
}