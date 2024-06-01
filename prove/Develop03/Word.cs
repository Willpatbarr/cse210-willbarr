using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void MakeWordBlank()
    {
        _isHidden = true;
    }
    public void MakeWordVisible()
    {
        _isHidden = false;
    }
    public string GetText()
    {
        if (_isHidden)
        {
            return "_____";
        }
        else
        {
            return _text;
        }
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
}