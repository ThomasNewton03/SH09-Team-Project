using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AppManager : MonoBehaviour
{
    // public Slider fontSizeSlider;  
    // public Slider buttonSizeSlider;  

    public GameObject settingsObject;
    Settings settings;

    void Awake(){
        //Load the button sizes from the player preferences
        settings = settingsObject.GetComponent<Settings>();
        settings.loadButtonSize();

        //Load the font sizes from the player preferences
        settings.getFontSizeSlider().GetComponent<FontSizeCustomise>().fontSizeSave();
        settings.loadFontSize();

        //Load the left-handed preferences from the player preferences
        settings.loadIsLeftHanded();
    }

    void OnApplicationQuit()
    {
        //Store the player settings so that they remain over difference loads of the app
        settings.saveFontSize(settings.getFontSize());
        settings.saveButtonSize(settings.getButtonSize());
        settings.saveIsLeftHanded(settings.getIsLeftHanded() ? 1 : 0);
        PlayerPrefs.Save();
    }
}
