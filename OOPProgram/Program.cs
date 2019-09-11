using System;

namespace OOPProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            Console.Write("Enter the number of years of experience you have: ");
            val = Console.ReadLine();
            int experience = Convert.ToInt32(val);
            Console.WriteLine("Executing a for loop:\nThis for loop will execute {0} number of times", (experience + 1));
            for (int i = 0; i <= experience; i++)
            {
                Console.WriteLine("You have {0} years of experience", i);
            }
        }
    }
}
