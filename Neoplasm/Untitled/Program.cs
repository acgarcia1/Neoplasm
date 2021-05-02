using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neoplasm.Untitled
{
    class Program
    {
        static void Main(string[] args)
        {                   
            Console.WriteLine("Welcome to NeoPlasm, a text adventure game inspired by Lovercraftian horror. What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0}. Now tell me, what is your age?", userName);
            int userAge;
            while (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.WriteLine("Please enter a number.");
            }
            Console.WriteLine("Very good. If you had to describe yourself to a stranger, would you say Brawny, Nimble, or Slight?");
            string userType = Console.ReadLine();
            userType = userType.ToUpper();          
            Console.WriteLine("Your choices will affect the outcome of the game, the options you have, and your chances of success. Good luck to you, brave soul for you now enter:");
            var userCharacter = new User(userAge, userName, userType);
            Console.WriteLine(userCharacter.Speed);
            Console.WriteLine(userCharacter.Strength);
            Console.WriteLine(userCharacter.Size);
            
            Console.ReadLine();
            Console.Clear();
            EventPrint.printTitle();
            Rooms.Room1(userCharacter.Speed, userCharacter.Size, userCharacter.Strength);
            Console.ReadLine();
        }
    }
}
