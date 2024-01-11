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
    public List<GameObject> buttonList;

    private float buttonSize;
    private float fontSize;
    private bool isLeftHanded;
    private Vector3 additionScaleVector = new Vector3 (1, 1, 1);


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
        setIsLeftHanded(leftHandToggle.isOn);
        menuLeftHand.SetActive(leftHandToggle.isOn);
        menuRightHand.SetActive(!leftHandToggle.isOn);
        mapLeftHand.SetActive(leftHandToggle.isOn);
        mapRightHand.SetActive(!leftHandToggle.isOn);
    }
    public void changeButtonSize()
    {
        for (int i = 0; i < buttonList.Count; i++)
        {
            buttonList[i].transform.localScale = additionScaleVector + additionScaleVector * buttonSizeSlider.value;
        }
    }

    public void checkMapSide()
    {
        mapLeftHand.SetActive(leftHandToggle);
        mapRightHand.SetActive(!leftHandToggle);
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