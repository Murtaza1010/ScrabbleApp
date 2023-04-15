// See https://aka.ms/new-console-template for more information
class ScrabbleMain
{
    static void Main(string[] args)
    {
        ScrabbleScore scorer = new ScrabbleScore();
        Console.WriteLine("Enter the word to Calculate your Score ( - to end):");
        string word = Console.ReadLine();
        while (word != "-") 
        {
            Console.WriteLine("The Score for " + word + " is " + scorer.GetScrabbleScore(word));
            Console.WriteLine("Enter the word to Calculate your Score ( - to end):");
            word = Console.ReadLine();
        }
        
    }
}