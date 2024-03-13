using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]

public class UpdateTextBoxStyle : MonoBehaviour
{

    private TMP_Text _textBox;
    
    // Add a method to the event defined in font size customise
    private void OnEnable()
    {
        FontSizeCustomise.UpdatedTheTextStyle += UpdateTextStyle;
    }

    // Remove the method from the event defined in font size customise
    private void OnDisable()
    {
        FontSizeCustomise.UpdatedTheTextStyle -= UpdateTextStyle;
    }


    private void Awake()
    {
        _textBox = GetComponent<TMP_Text>();
    }

    // Invoked on changes made to the stylesheet, see FontSizeCustomise
    private void UpdateTextStyle(string styleName)
    {
        // If current style not affected then ignore
        if (_textBox.textStyle.name != styleName) return;

        // Reload style from stylesheet
        _textBox.textStyle = TMP_Settings.defaultStyleSheet.GetStyle(styleName);

        /* Make sure text is displayed correctly when across multiple pages */
        int lastPage = _textBox.textInfo.pageCount - 1;
        /**/
        if (_textBox.pageToDisplay > lastPage) _textBox.pageToDisplay = lastPage;
        /**/
    }
}
