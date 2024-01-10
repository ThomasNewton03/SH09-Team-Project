using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Settings : MonoBehaviour {

    public Slider buttonSizeSlider;
    public Slider fontSizeSlider;
    public Toggle leftHandToggle;
    public GameObject leftHand;
    public GameObject rightHand;

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
            leftHand.SetActive(true);
            rightHand.SetActive(false);
        }
        else
        {
            leftHand.SetActive(false);
            rightHand.SetActive(true);
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