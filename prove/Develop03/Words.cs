using System;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string word)
    {
        this._text = word;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public string Show()
    {
        return _text;
    }
    public bool IsHidden()
    {
        return _isHidden;

    }

    public string GetDisplayText()
    {
        return _text;
    }

}