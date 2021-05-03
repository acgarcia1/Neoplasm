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
            string play = "Y";

            Console.WriteLine("Welcome to NeoPlasm, a text adventure game inspired by Lovercraftian horror.\nWhat is your name?");           
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
            Console.WriteLine("One last question. Don't overthink it. What scares you most: Spiders, Cows, or the Ocean?");
            string userMon = Console.ReadLine();
            userMon = userMon.ToUpper();
            var userMonster = new userMonster(userMon);
            Console.WriteLine("Your choices will affect the outcome of the game, the options you have, and your chances of success.\nGood luck to you, brave soul, for you now enter:");
            var userCharacter = new User(userAge, userName, userType);        
          
            Console.ReadLine();
            while (play != "N")
            {
                Console.Clear();
                EventPrint.printTitle();
                Rooms.Room1(userCharacter.Speed, userCharacter.Size, userCharacter.Strength, ref userCharacter);

                if(userCharacter.axe == true || userCharacter.key == true || userCharacter.skateBoard == true)
                {
                    finalRoom.Finale(userMonster, userCharacter);
                }

                Console.WriteLine("Would you like to try again? (Y/N)");
                play = Console.ReadLine();
                play = play.ToUpper();
                userCharacter.deaths += 1;
                userCharacter.axe = false;
                userCharacter.key = false;
                userCharacter.skateBoard = false;
            }
            EventPrint.printGoodbye(userCharacter.deaths);
        }
    }
}
