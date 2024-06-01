using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText;
        string book;
        int chapter;
        int verse;
        int endVerse;
        while(true)
        {
            Console.Write("\nWelcome to scripture memorizer, would you like to \nuse a preloaded scripture (type'1') \nor enter your own? (type '2')\n: ");
            string menuInput = Console.ReadLine();
            
            if (menuInput == "1")
            {
                scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
                book = "Proverbs";
                chapter = 3;
                verse = 3;
                endVerse = 6;
                break;
            }
            else if (menuInput == "2")
            {
                Console.Write("Please Enter the book of the scripture: ");
                book = Console.ReadLine();
                Console.Write("Please Enter the chapter: ");
                chapter = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Enter the verse it starts on: ");
                verse = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Enter the verse it ends on (if it ends on the same verse still enter it): ");
                endVerse = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Please Enter the text for the scripture: ");
                scriptureText = Console.ReadLine();
                break;
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2");
            }
        }

        List<Word> words = new List<Word>();
        foreach (var word in scriptureText.Split(" "))
        {
            words.Add(new Word(word));
        }

        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(words, reference);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress Enter to hide words, or type quit to exit");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideWords();

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden");
                break;
            }
        }
    }
}