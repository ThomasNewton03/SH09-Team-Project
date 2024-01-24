using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class PageNavigation : MonoBehaviour
{
    [SerializeField] private TMP_Text _textBox;
    [TextArea(5,10)][SerializeField] private string FirstChunkOfText;
    [TextArea(5,10)][SerializeField] private string SecondChunkOfText;

    private List<string> _textList => new List<string> {FirstChunkOfText, SecondChunkOfText};
    private int _textindex  = 0;
    private int _currentTextPages => _textBox.textInfo.pageCount;
    private int _currentPage => _textBox.pageToDisplay;

    private void Awake()
    {
        _textBox = GetComponent<TMP_Text>();
    }

    [ContextMenu("Display Next Page")]
    public void DisplayNextPage()
    {
        if (_currentPage < _currentTextPages)
        {
            _textBox.pageToDisplay++;
        }
        else{
            _textindex++;
            if (_textindex >= _textList.Count)
            {
                _textindex = 0;
            }

            _textBox.text = _textList[_textindex];
            _textBox.pageToDisplay = 1;
        }
    }

    [ContextMenu("Display Previous Page")]
    public void DisplayPreviousPage()
    {
        if (_currentPage > 1)
        {
            _textBox.pageToDisplay--;
        }
        else{
            _textindex--;
            if (_textindex < 0)
            {
                _textindex = 0;
            }
            else
            {
                _textBox.text = _textList[_textindex];
                _textBox.pageToDisplay = _currentTextPages;
            }
            
        }
    }
}
