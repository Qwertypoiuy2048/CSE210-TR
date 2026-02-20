using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        String script = "Now behold, a marvelous work is about to come forth among the children of men. Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day. Therefore, if ye have desires to serve God ye are called to the work; For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might, the same layeth up in store that he perisheth not, but bringeth salvation to his soul; And faith, hope, charity and love, with an eye single to the glory of God, qualify him for the work. Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence. Ask, and ye shall receive; knock, and it shall be opened unto you. Amen.";
        string script1 = "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.";
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
