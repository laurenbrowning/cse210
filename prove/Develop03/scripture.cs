using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();
        string[] splitText = text.Split(' ');

        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }
    public bool HideRandWords()
    {
        List<Word> visibleWords = NotHidden();
        if (visibleWords.Count < 2)
            return false;
    
        Random random = new Random();
        int randIndex1 = random.Next(visibleWords.Count);
        int randIndex2;
        do
        {
            randIndex2 = random.Next(visibleWords.Count);
        }

        while (randIndex1 == randIndex2);

        visibleWords[randIndex1].Hide();
        visibleWords[randIndex2].Hide();
        return true;
    }
 
    public void Display()
    {
        Console.WriteLine($"{_reference} - ");
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                Console.Write(new string('_', word.Show().Length) + " ");
            }
            else
            {
                Console.Write(word.Show() + " ");
            }
        }
    }

    private List<Word> NotHidden()
    {
        List<Word> visWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                visWords.Add(word);
        }
            return visWords;
    }
}