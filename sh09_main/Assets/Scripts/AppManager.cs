using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AppManager : MonoBehaviour
{
    public Slider fontSizeSlider;  
    void Start(){
        fontSizeSlider.GetComponent<FontSizeCustomise>().fontSizeSave();
        fontSizeSlider.value = PlayerPrefs.GetFloat("fontSizeScalar");
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("fontSizeScalar", fontSizeSlider.value);
        PlayerPrefs.Save();
    }
}
