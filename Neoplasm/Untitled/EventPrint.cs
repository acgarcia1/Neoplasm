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
							  "dragging you down to join the eternal Neoplasm growing from out failures.");
		}

		public static void printTitle()
		{
			Console.WriteLine("------------\n | NEOPLASM |\n------------");
		}

		public static void PrintOpening()
		{
			Console.WriteLine("Welcome to NeoPlasm, a text adventure game inspired by Lovercraftian horror. What is your name?");
			userName = Console.ReadLine();
			Console.WriteLine("Nice to meet you {0}. Now tell me, what is your age?", userName);
			userAgeString = Console.ReadLine();
			userAge = Convert.ToInt32(userAgeString);
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
                    BrawnyScientist userCharacter = new BrawnyScientist(userAge, userName);
                }
				else if (userSpecial == "ARCHEOLOGIST") 
                {
					BrawnyArcheologist userCharacter = new BrawnyArcheologist(userName, userAge);
                }
				else
                {
					BrawnyTrade userCharacter = new BrawnyTrade(userAge, userName);
                }
            }
			else if (userType == "NIMBLE")
            {
				if (userSpecial == "SCIENTISTS")
                {
					NimbleScientist userCharacter = new NimbleScientist(userAge, userName);
                }
				else if (userSpecial == "ARCHEOLOGIST")
                {
					NimbleArcheologist userCharacter = new NimbleArcheologist(userAge, userName);
                }
				else
                {
					NimbleTradeWorker userCharacter = new NimbleTradeWorker(userAge, userName);
                }
            }
			else
            {
				if (userSpecial == "SCIENTISTS")
                {
					SlightScientist userCharacter = new SlightScientist(userName, userAge);

                }
				else if (userSpecial == "ARCHEOLOGIST")
                {
					SlightArcheologist userCharacter = new SlightArcheologist(userAge, userName);
                }
				else
                {
					SlightTradeWorker userCharacter = new SlightTradeWorker(userAge, userName);
                }
            }
			printTitle();

		}
	}
}
