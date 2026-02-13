using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        
        string script = "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.";
        string[] words = script.Split(' ');
        List<string> wl = words.ToList();

        Scripture scripture = new Scripture("Mosiah","2","41",wl);

        bool done = scripture.AreWeDoneYet();
        do
        {
            Console.Clear();
            done = scripture.AreWeDoneYet();
            scripture.Display();
            Console.Write("\n\nPress enter to continue or type 'quit' to exit. You may also type 'help' to reveal words  ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "quit":
                    done = true;
                    break;
                case "help":
                    Console.Clear();
                    // Console.WriteLine("LOL help has not been programmed\n\n");
                    Console.Write("How many words should be shown? ");
                    int help = int.Parse(Console.ReadLine());
                    scripture.GetHelp(help);

                    break;

                default:
                    scripture.HideRandom(3);
                    break;
            }
        } while (!done);
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\n\nThanks for using the Scripture Memorizer!\n");

    }
}
