using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class PageNavigation : MonoBehaviour
{
    [SerializeField] private TMP_Text _textBox;
    public GameObject QuizContainer;
    public GameObject InfoContainer;
    [TextArea(5,10)][SerializeField] private string FirstChunkOfText;
    // [TextArea(5,10)][SerializeField] private string SecondChunkOfText;

    private List<string> _textList => new List<string> {FirstChunkOfText}; // , SecondChunkOfText};
    private int _textindex  = 0;
    private int _currentTextPages => _textBox.textInfo.pageCount;
    private int _currentPage => _textBox.pageToDisplay;

    // Get Text box
    private void Awake()
    {
        _textBox = GetComponent<TMP_Text>();
    }
    
    // Called by Info page right button click
    [ContextMenu("Display Next Page")]
    public void DisplayNextPage()
    {
        // Move page up if still pages to go
        if (_currentPage < _currentTextPages)
        {
            _textBox.pageToDisplay++;
        }
        // If at last page, move to quiz 
        else if (_currentPage == _currentTextPages){
            InfoContainer.SetActive(false);
            QuizContainer.SetActive(true);
        }
    }

    // Called by Info page left button click
    [ContextMenu("Display Previous Page")]
    public void DisplayPreviousPage()
    {
        // If not on first page go back a page
        if (_currentPage > 1)
        {
            _textBox.pageToDisplay--;
        }
    }
}
