using UnityEngine;
public class Settings : MonoBehaviour{

    int buttonSize;
    int fontSize;
    bool isLeftHanded;

    public Settings(int buttonSize, int fontSize, bool isLeftHanded) {
        this.buttonSize = buttonSize;
        this.fontSize = fontSize;
        this.isLeftHanded = isLeftHanded;
    }


    public void setButtonSize(int buttonSize){
        this.buttonSize = buttonSize;
    }

    public int getButtonSize(){
        return buttonSize;
    }

    public void setFontSize(int fontSize){
        this.fontSize = fontSize;
    }

    public int getFontSize(){
        return fontSize;
    }

    public void setIsLeftHanded(bool isLeftHanded){
        this.isLeftHanded = isLeftHanded;
    }

    public bool getIsLeftHanded(){
        return isLeftHanded;
    }

}