using System;
/*
Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
Display the journal - Iterate through all entries in the journal and display them to the screen.
Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. 
This should replace any entries currently stored in the journal.
Provide a menu that allows the user choose these options
Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
Who was the most interesting person I interacted with today?
What was the best part of my day?
How did I see the hand of the Lord in my life today?
What was the strongest emotion I felt today?
If I had one thing I could do over today, what would it be?
Your interface should generally follow the pattern shown in the video demo below.
In addition, your program must:

Contain classes for the major components in the program.
Contain at least two classes in addition to the Program class.
Demonstrate the principle of abstraction by using member variables and methods appropriately.

For the core requirements you do not need to worry about the following:

Saving your file as a .csv file requires you to handle commas and quotes in the content appropriately. At this point, you can ignore that and just choose a symbol for a separator that you think is unlikely to show up in the content (such as | or ~ or ~|~).
You do not need to store the date as an actual C# DateTime object in your class or in the file. You can simply store it as a string.
*/
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!\n");


        Journal journal1 = new Journal();

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
                // new entry object, pick a prompt, store date, prompt, and input
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
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
                break;



                case "4":
                // Get filename, write to file, CSV use "," as separator

                filename = "myFile.txt";
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    // You can add text to the file with the WriteLine method
                    outputFile.WriteLine("This will be the first line in the file.");
                    
                    // You can use the $ and include variables just like with Console.WriteLine
                    string color = "Blue";
                    outputFile.WriteLine($"My favorite color is {color}");
                }
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
}
