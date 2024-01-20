using System;
public class Journal
    {
        public List<Entry> _entries;


         public Journal()
        {
            _entries = new List<Entry>();
        }

        public void AddEntry(string prompt)
        {
            Console.Write(prompt  + " ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            _entries.Add(new Entry(prompt, response, date));
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
        public void SaveToFile()
        {
            Console.Write("Enter Filename: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,Prompt,Response");

                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt().Replace(",", ",,")},{entry.GetResponse().Replace(",", ",,")}");
                }
            }

            Console.WriteLine("Saved");
        }

        public void LoadFromFile()
        {
            Console.Write("Enter filename: ");
            string filename = Console.ReadLine();
            _entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string headerLine = reader.ReadLine(); // Read and discard the header line

                while (!reader.EndOfStream)
                {
                    string entryLine = reader.ReadLine();
                    string[] fields = entryLine.Split(',');

                    string date = fields[0];
                    string prompt = fields[1].Replace(",,", ",");
                    string response = fields[2].Replace(",,", ",");

                    _entries.Add(new Entry(prompt, response, date));
                }
            }

            Console.WriteLine("Loaded");
        }
    }


        
    //     AddEntry(newEntry : Entry) : void
    //     DisplayAll() : void
    //     SaveToFile(file : string)
    //     LoadFromFile(file : string)
    