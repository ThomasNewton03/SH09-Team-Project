using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AppManager : MonoBehaviour
{
    public Slider fontSizeSlider;  
    public Slider buttonSizeSlider;  
    void Start(){
        fontSizeSlider.GetComponent<FontSizeCustomise>().fontSizeSave();
        fontSizeSlider.value = PlayerPrefs.GetFloat("fontSizeScalar");

        buttonSizeSlider.value = PlayerPrefs.GetFloat("buttonSizeScalar");
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("fontSizeScalar", fontSizeSlider.value);
        PlayerPrefs.SetFloat("buttonSizeScalar", buttonSizeSlider.value);
        PlayerPrefs.Save();
    }
}
