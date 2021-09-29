using System;

namespace Day3Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                //Console.Write("Please enter a number from 1 to 10: ");

                //get input from user
                Console.Write("Please enter a number from 1 to 65: ");
                string value = Console.ReadLine();
                int input;

                //check if user input is a number
                bool success = int.TryParse(value, out input);

                if (success)
                {
                    //check if user input is nonnegative
                    if (input >= 0)
                    {
                        Console.WriteLine(ReturnFactorial(input)); //call method

                        //ask user if they want to repeat
                        while (true)
                        {
                            Console.Write("Would you like to continue? (y/n): ");
                            string answer = Console.ReadLine();

                            if (answer == "n")
                            {
                                Console.WriteLine("\nGoodbye!");
                                repeat = false;
                                break;
                            }
                            else if (answer == "y")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid input. Try again.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Try again.");
                }
                
            }

        }

        public static long ReturnFactorial(int num)
        {
            /*long result = 1;
            for (int i = num; i > 0; i--)
            {
                result = result * i;
            }
            */

            if (num <= 1)
            {
                return 1;
            }

            return (num * ReturnFactorial(num - 1));
        }
        
    }
}
