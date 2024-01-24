using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    public List<GameObject> buttonList;

    private float buttonSize;
    private float fontSize;
    private bool isLeftHanded = false;


    public Settings(int buttonSize, int fontSize, bool isLeftHanded) {
        this.buttonSize = buttonSize;
        this.fontSize = fontSize;
        this.isLeftHanded = isLeftHanded;
    }

    void Update(){
        //Debug.Log("button size : " + buttonSizeSlider.value);
    }

    //toggleLeftHanded() is used in the toggle option, it will set leftHanded bool to true or false, and then set the menu and map buttons to right/left.
    public void toggleLeftHanded()
    {
        setIsLeftHanded(leftHandToggle.isOn);
        menuLeftHand.SetActive(leftHandToggle.isOn);
        menuRightHand.SetActive(!leftHandToggle.isOn);
        mapLeftHand.SetActive(leftHandToggle.isOn);
        mapRightHand.SetActive(!leftHandToggle.isOn);
    }

    //changeButtonSize() changes all the button sizes but using scale. All buttons are assumed to be on scale of 1,1,1. 
    //if a new button is added please keep scale at 1,1,1 for this to work
    public void changeButtonSize()
    {
        Vector3 additionScaleVector = Vector3.one;
        for (int i = 0; i < buttonList.Count; i++)
        {
            buttonList[i].transform.localScale = additionScaleVector + (additionScaleVector * buttonSizeSlider.value);
            Debug.Log(buttonSizeSlider.value);
            Debug.Log(additionScaleVector);
        }
    }

    //checkMapSide() is there to be used as a check for which side map should be at and sets it active.
    public void checkMapSide()
    {
        mapLeftHand.SetActive(isLeftHanded);
        mapRightHand.SetActive(!isLeftHanded);
    }

    //checkMenuSide() is there to be used as a check for which side menu button should be at and sets it as active.
    public void checkMenuSide()
    {
        menuLeftHand.SetActive(isLeftHanded);
        menuRightHand.SetActive(!isLeftHanded);
    }

    //checkInfoExitSide() is there to be used a check for which side the info exit button should be at and sets it as active.
    public void checkInfoExitSide()
    {
        infoExitLeftHand.SetActive(isLeftHanded);
        infoExitRightHand.SetActive(!isLeftHanded);
    }

    public void setButtonSize(int buttonSize){
        this.buttonSize = buttonSize;
    }

    public float getButtonSize(){
        return buttonSizeSlider.value;
    }

    public void setFontSize(int fontSize){
        this.fontSize = fontSize;
    }

    public float getFontSize(){
        return fontSizeSlider.value;
    }

    public void setIsLeftHanded(bool isLeftHanded){
        this.isLeftHanded = isLeftHanded;
    }

    public bool getIsLeftHanded(){
        return isLeftHanded;
    }

}