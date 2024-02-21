using System.Collections;
using System.Collections.Generic;
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
    public GameObject mapEventButton;
    public GameObject extendedButtonsRightHand;
    public GameObject extendedButtonsLeftHand;
    public GameObject infoExitRightHand;
    public GameObject infoExitLeftHand;
    public GameObject InfoPage;
    public GameObject InventoryPage;
    public GameObject ProfilePage;
    public GameObject SettingsPage;
    public ARSession Session;
    public List<GameObject> buttonList;

    public GameObject introPage;

    // private float buttonSize;
    // private float fontSize;
    // private bool isLeftHanded = false;



    // public Settings(int buttonSize, int fontSize, bool isLeftHanded) {
    //     this.buttonSize = buttonSize;
    //     this.fontSize = fontSize;
    //     this.isLeftHanded = isLeftHanded;
    // }

    // void Update(){
    //     //Debug.Log("button size : " + buttonSizeSlider.value);
    // }

    //toggleLeftHanded() is used in the toggle option, it will set leftHanded bool to true or false, and then set the menu and map buttons to right/left.
    public void toggleLeftHanded()
    {
        if (!introPage.active || !InfoPage.active){
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
        // buttonSize = buttonSizeSlider.value;

        Vector3 additionScaleVector = Vector3.one;
        for (int i = 0; i < buttonList.Count; i++)
        {
            buttonList[i].transform.localScale = additionScaleVector + (additionScaleVector * buttonSizeSlider.value);
            //Debug.Log(buttonSizeSlider.value);
            //Debug.Log(additionScaleVector);
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
        InfoPage.SetActive(true);
        InventoryPage.SetActive(false);
        ProfilePage.SetActive(false);
        SettingsPage.SetActive(false);

        closeUI();
    }
    public void swapToInventoryPage()
    {
        UICheck();
        InfoPage.SetActive(false);
        InventoryPage.SetActive(true);
        ProfilePage.SetActive(false);
        SettingsPage.SetActive(false);
        closeAR();
    }
    public void swapToProfilePage()
    {
        UICheck();
        InfoPage.SetActive(false);
        InventoryPage.SetActive(false);
        ProfilePage.SetActive(true);
        SettingsPage.SetActive(false);
        closeAR();
    }
    public void swapToSettingsPage()
    {
        UICheck();
        InfoPage.SetActive(false);
        InventoryPage.SetActive(false);
        ProfilePage.SetActive(false);
        SettingsPage.SetActive(true);
        closeAR();
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

    public void saveButtonSize(float saveButtonSize)
    {
        PlayerPrefs.SetFloat("buttonSizeScalar", saveButtonSize);
    }

    public void loadButtonSize()
    {
        if (PlayerPrefs.HasKey("buttonSizeScalar")){
           setButtonSize(PlayerPrefs.GetFloat("buttonSizeScalar"));
           changeButtonSize();
        }else{
            setButtonSize((float)0.125);
        }
    }

    public void saveFontSize(float saveFontSize)
    {
        PlayerPrefs.SetFloat("fontSizeScalar", saveFontSize);
    }

    public void loadFontSize()
    {
        if (PlayerPrefs.HasKey("fontSizeScalar")){
           setFontSize(PlayerPrefs.GetFloat("fontSizeScalar"));
        }else{
            setFontSize((float)1.3);
        }
    }

    public void saveIsLeftHanded(int saveIsLeftHanded){
        PlayerPrefs.SetInt("isLeftHanded", saveIsLeftHanded);
    }

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

    //Uses closes AR session, so its not enabled while not in that page.
    public void closeAR()
    {
        Session.enabled = false;
    }
}