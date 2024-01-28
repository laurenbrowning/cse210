using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = startVerse;
        this._endVerse = endVerse;
    }
    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = verse;
    }
    public string GetDisplayText()
    {
        if(_verse == _endVerse)
            return $"{_book} {_chapter}, {_verse}";
        else
            return $"{_book} {_chapter} - {_verse}-{_endVerse}";
    }

}