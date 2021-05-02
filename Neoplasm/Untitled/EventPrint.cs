using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public class EventPrint
	{
		public static string userName;
		public static string userAgeString;
		public static int userAge;
		public static string userType;
		public static string userSpecial;
		public static void printDeath()
		{
			Console.WriteLine("You have failed to discovery the mystery and escape. Dark tendrils from the black earth reach around you," +
							  "dragging you down to join the eternal Neoplasm growing from our failures.");
		}

		public static void printTitle()
		{
			string titleTop = "------------";
			string titleMid = "| NEOPLASM |";
			string titleBottom = "------------";
			//Console.SetCursorPosition((Console.WindowWidth - titlePrint.Length) / 2, Console.CursorTop);
			Console.WriteLine(String.Format("{0," + (Console.WindowWidth / 2) + "}", titleTop));
			Console.WriteLine(String.Format("{0," + (Console.WindowWidth / 2) + "}", titleMid));
			Console.WriteLine(String.Format("{0," + (Console.WindowWidth / 2) + "}", titleBottom));
			//Console.WriteLine("------------\n| NEOPLASM |\n------------");
		}

		public static void PrintOpening()
		{
			Object userCharacter;
			Console.WriteLine("Welcome to NeoPlasm, a text adventure game inspired by Lovercraftian horror. What is your name?");
			userName = Console.ReadLine();
			Console.WriteLine("Nice to meet you {0}. Now tell me, what is your age?", userName);		
			int userAge;
			while(!int.TryParse(Console.ReadLine(), out userAge))
            {
				Console.WriteLine("Please enter a number.");
            }
			Console.WriteLine("Very good. If you had to describe yourself to a stranger, would you say Brawny, Nimble, or Slight?");
			userType = Console.ReadLine();
			userType = userType.ToUpper();
			Console.WriteLine("What is your speciality, Scientist, Archeologist, or Trade Worker?");
			userSpecial = Console.ReadLine();
			userSpecial = userSpecial.ToUpper();
			Console.WriteLine("Your choices will affect the outcome of the game, the options you have, and your chances of success. Good luck to you, brave soul for you now enter:");	
			
			if (userType == "BRAWNY")
            {
				if (userSpecial == "SCIENTIST")
				{
                    userCharacter = new BrawnyScientist(userAge, userName);
                }
				else if (userSpecial == "ARCHEOLOGIST") 
                {
					userCharacter = new BrawnyArcheologist(userName, userAge);
                }
				else
                {
					userCharacter = new BrawnyTrade(userAge, userName);
                }
            }
			else if (userType == "NIMBLE")
            {
				if (userSpecial == "SCIENTISTS")
                {
					userCharacter = new NimbleScientist(userAge, userName);				
                }
				else if (userSpecial == "ARCHEOLOGIST")
                {
					userCharacter = new NimbleArcheologist(userAge, userName);
                }
				else
                {
					userCharacter = new NimbleTradeWorker(userAge, userName);
                }
            }
			else
            {
				if (userSpecial == "SCIENTISTS")
                {
					userCharacter = new SlightScientist(userName, userAge);

                }
				else if (userSpecial == "ARCHEOLOGIST")
                {
					userCharacter = new SlightArcheologist(userAge, userName);
                }
				else
                {
					userCharacter = new SlightTradeWorker(userAge, userName);
                }
            }
			Console.ReadLine();
			Console.Clear();
			printTitle();			
		}
	}
}
