using System;

namespace Lab3_5_Thomas_Morris
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "viagra";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("This message is spam.");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("This message is not spam.");
            }
        }
    }
}
