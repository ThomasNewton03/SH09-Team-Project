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

    private float buttonSize;
    private float fontSize;
    private bool isLeftHanded;

    public Settings(int buttonSize, int fontSize, bool isLeftHanded) {
        this.buttonSize = buttonSize;
        this.fontSize = fontSize;
        this.isLeftHanded = isLeftHanded;
    }

    void Update(){
        Debug.Log("button size : " + buttonSizeSlider.value);
    }

    public void toggleLeftHanded()
    {
        if (leftHandToggle.isOn)
        {
            menuLeftHand.SetActive(true);
            menuRightHand.SetActive(false);
            mapLeftHand.SetActive(true);
            mapRightHand.SetActive(false);

        }
        else
        {
            menuLeftHand.SetActive(false);
            menuRightHand.SetActive(true);
            mapLeftHand.SetActive(false);
            mapRightHand.SetActive(true);
        }
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