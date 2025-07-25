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

    // Get Default style Sheet
    private TMP_StyleSheet _styleSheet => TMP_Settings.defaultStyleSheet;
    // Initialise list of styles that can be edited from style sheet
    [SerializeField] private string[] styleNames;
    // Sends message to UpdateTextBoxStyle script
    public static Action<string> UpdatedTheTextStyle;

    private int[] originalSizes;
    private int length;

    // Called by Slider when value changes via unity inspector
    // fontSizeScalar is value of slider
    public void ChangeFontSize(float fontSizeScaler){
        
        // For every style in the sheet that is editable...
        for (int i = 0; i<length ; i++){

            // ...get the style information for the current style
            TMP_Style style = _styleSheet.GetStyle(styleNames[i]);
            
            // Style not found
            if (style == null){
                Debug.LogError($"No style with name {styleNames[i]} found in default style sheet.");    
                return;
            }

            // Pattern searched for, Style must contain <size={Any one or two digit number}>
            // Hence does not support using size defined by em, %, pixel, etc. 
            Regex regex = new Regex(@"<size=\d+>");
            
            // Relative font scaling, on integers
            double newSize = System.Math.Round(originalSizes[i]*fontSizeScaler,0);
            
            // Gets string of all opening html styling tags, replaces found pattern with modified values
            string modifiedOpeningDefinition = regex.Replace(style.styleOpeningDefinition, $"<size={newSize}>");

            // Brute force into Style class to modify opening definition stored
            FieldInfo openingDefinitionField = typeof(TMP_Style).GetField("m_OpeningDefinition", BindingFlags.NonPublic | BindingFlags.Instance );

            if (openingDefinitionField != null) 
                openingDefinitionField.SetValue(style, modifiedOpeningDefinition);

            
            style.RefreshStyle();

            // Send message that style has changed
            UpdatedTheTextStyle?.Invoke(styleNames[i]);
        }

    }

    public void fontSizeSave(){

        length = styleNames.Length;
        originalSizes = new int[length];
        // For every style...
        for (int i = 0; i<length ; i++)
        {
            // ...get the style definition from the stylesheet
            TMP_Style style = _styleSheet.GetStyle(styleNames[i]);
            
            // Get the font sizes saved or if first use of the app save the currently defined sizes for future reference
            string originalSizeString;
            int originalSize;
            if (PlayerPrefs.HasKey("defaultfontSize" + i)){
                originalSizes[i] = PlayerPrefs.GetInt("defaultfontSize" + i);
            }else{
                originalSizeString= Regex.Match(style.styleOpeningDefinition, @"<size=\d+>").Value;
                originalSize = Int32.Parse(Regex.Match(originalSizeString, @"\d+").Value);
                originalSizes[i] = originalSize;
                PlayerPrefs.SetInt("defaultfontSize" + i, originalSizes[i]);
            }
        }
    }
    
    // An attempt to save the original values back to the stylesheet on app quit, similar to the ChangeFontSize method above, does not currently get called, could be useful in future
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