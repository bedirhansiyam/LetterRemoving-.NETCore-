namespace LetterRemoving;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a word and number (word,number) : ");

        string[] input = Console.ReadLine().Split(',');
        string word = input[0];
        int number = Convert.ToInt32(input[1]);

        if(number > word.Length-1)
        {
            Console.WriteLine("Result : " + word);
        }
        else
            Console.WriteLine("Result : " + word.Remove(number,1));
    }
}
