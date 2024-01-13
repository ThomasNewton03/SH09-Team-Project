using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppClose : MonoBehaviour
{
    public GameObject fontSizeSlider; 

    void OnApplicationQuit()
    {
        fontSizeSlider.SetActive(true);
    }
}
