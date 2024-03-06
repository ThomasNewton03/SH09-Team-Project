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
        // PlayerPrefs.DeleteAll();
        settings = settingsObject.GetComponent<Settings>();
        settings.loadButtonSize();

        settings.getFontSizeSlider().GetComponent<FontSizeCustomise>().fontSizeSave();
        settings.loadFontSize();

        settings.loadIsLeftHanded();
    }

    void OnApplicationQuit()
    {
        settings.saveFontSize(settings.getFontSize());
        settings.saveButtonSize(settings.getButtonSize());
        settings.saveIsLeftHanded(settings.getIsLeftHanded() ? 1 : 0);
        PlayerPrefs.Save();

        // 0 = false
    }
}
