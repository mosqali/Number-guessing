using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string welcomeText = "--Welcome to my Number Guessing Game--";
            string PressEnterToContinue = "Press Enter button to continue";

            Random rnd = new Random();

            int userInput;

            SetWindowSize(50, 30);

            SetTextInCenter(welcomeText);
            Console.Write("\n");
            SetTextInCenter(PressEnterToContinue);
            Console.WriteLine("\n");

            Console.ReadLine();

            Console.WriteLine("  Guess the number between 1-100");

            int num = rnd.Next(1,100);

            do
            {
                Console.Write("  Your Number: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == num)
                {
                    Console.WriteLine("  Exactly!! The correct number is " + num);
                }
                else if(userInput <= num)
                {
                    Console.WriteLine("  higher!\n");
                }
                else if (userInput >= num)
                {
                    Console.WriteLine("  lower!\n");
                }

            }while(num != userInput);

            void SetTextInCenter(string Text)
            {
                Console.SetCursorPosition((Console.WindowWidth - Text.Length) / 2, Console.CursorTop);
                Console.WriteLine(Text);
            }

            void SetWindowSize(int x, int y)
            {
                Console.SetWindowSize(x, y);
            }

            Console.ReadKey();
        }
    }
}
