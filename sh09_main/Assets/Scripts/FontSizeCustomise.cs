using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FontSizeCustomise : MonoBehaviour
{

    private TMP_StyleSheet _styleSheet => TMP_Settings.defaultStyleSheet;
    [SerializeField] private string[] styleNames;
    public static Action<string> UpdatedTheTextStyle;

    private int[] originalSizes;
    int length;

    public void ChangeFontSize(float fontSizeScaler){
        
        for (int i = 0; i<length ; i++){

            TMP_Style style = _styleSheet.GetStyle(styleNames[i]);

            if (style == null){
                Debug.LogError($"No style with name {styleNames[i]} found in default style sheet.");    
                return;
            }

            Regex regex = new Regex(@"<size=\d+>");

            double newSize = System.Math.Round(originalSizes[i]*fontSizeScaler,0);

            string modifiedOpeningDefinition = regex.Replace(style.styleOpeningDefinition, $"<size={newSize}>");

            FieldInfo openingDefinitionField = typeof(TMP_Style).GetField("m_OpeningDefinition", BindingFlags.NonPublic | BindingFlags.Instance );

            if (openingDefinitionField != null) 
                openingDefinitionField.SetValue(style, modifiedOpeningDefinition);

            style.RefreshStyle();

            UpdatedTheTextStyle?.Invoke(styleNames[i]);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        length = styleNames.Length;
        originalSizes = new int[length];
        for (int i = 0; i<length ; i++)
        {
            TMP_Style style = _styleSheet.GetStyle(styleNames[i]);
            string originalSizeString = Regex.Match(style.styleOpeningDefinition, @"<size=\d+>").Value;
            int originalSize = Int32.Parse(Regex.Match(originalSizeString, @"\d+").Value);
            originalSizes[i] = originalSize;
            // Debug.Log(originalSize);
        }
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Debug.Log("button size : " + fontSizeSlider.value);
    // }

    void OnApplicationQuit()
    {
        for (int i = 0; i<length ; i++){
            
            TMP_Style style = _styleSheet.GetStyle(styleNames[i]);

            if (style == null){
                Debug.LogError($"No style with name {styleNames[i]} found in default style sheet.");    
                return;
            }

            Regex regex = new Regex(@"<size=\d+>");

            string modifiedOpeningDefinition = regex.Replace(style.styleOpeningDefinition, $"<size={originalSizes[i]}>");

            FieldInfo openingDefinitionField = typeof(TMP_Style).GetField("m_OpeningDefinition", BindingFlags.NonPublic | BindingFlags.Instance );

            if (openingDefinitionField != null) 
                openingDefinitionField.SetValue(style, modifiedOpeningDefinition);

            style.RefreshStyle();

            UpdatedTheTextStyle?.Invoke(styleNames[i]);
        }
    }
}