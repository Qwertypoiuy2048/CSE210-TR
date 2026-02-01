using System;
/*
Finally got it working
*/

// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!\n");


        Journal journal1 = new Journal();

        journal1._prompts = ["Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"];
        journal1._entries = [];
        string filename = "myFile.txt";
        string choice = "0";
        bool done = false;
        while (!done)
        {
            Console.WriteLine($"Select one of the following:");
            Console.WriteLine($"1. Write");
            Console.WriteLine($"2. Display");
            Console.WriteLine($"3. Load");
            Console.WriteLine($"4. Save");
            Console.WriteLine($"5. Quit");
            Console.Write($"What would you like to do? ");
            choice = Console.ReadLine();
            
            switch (choice){
                case "1":
                Entry entry = journal1.WriteEntry();
                journal1._entries.Add(entry);
                break;
                

                case "2":
                journal1.Display();
                break;


                case "3":
                
                filename = "myFile.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string firstName = parts[0];
                    string lastName = parts[1];
                }
                Console.WriteLine("\nJournal Loaded!\n");
                break;


                case "4":
                // Get filename, write to file, CSV use "," as separator

                filename = "myFile.txt";
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    // You can add text to the file with the WriteLine method
                    foreach (Entry i in journal1._entries)
                    {
                        
                    }
                    Entry a = journal1._entries[0];
                    
                    outputFile.WriteLine($"{a._date},{a._prompt},{a._prompt}");
                }
                Console.WriteLine("\nJournal Saved!\n");
                break;


                case "5":
                Console.WriteLine("\nGood job writing in your journal today!\n");
                done = true;
                break;


                default:
                Console.WriteLine("Please select a valid option\n");
                break;
            }
        }
    }

    public void Save()
    {
        
    }
    public void Load()
    {
        
    }
}
