using System;

public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;

        public Entry(string prompt, string response, string date)
        {
            _promptText = prompt;
            _entryText = response;
            _date = date;
        }

        public string GetPrompt()
        {
            return _promptText;
        }

        public string GetResponse()
        {
            return _entryText;
        }

        public string GetDate()
        {
            return _date;
        }

        public override string ToString()
        {
            return $"Date: {_date} - Prompt: {_promptText} \n{_entryText}\n";
        }
       
       
       
       
       
       public void Display()
        {

        }
    }