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
		public static void printDeath(ref User character)
		{
			Console.WriteLine("You have failed to discovery the mystery and escape. Dark tendrils from the black earth reach around you,\n" +
							  "dragging you down to join the eternal Neoplasm growing from our failures.\n");
			character.axe = false;
			character.key = false;
			character.skateBoard = false;
		
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

		public static void printGoodbye(int deaths)
		{
			Console.WriteLine("Thank you for playing Neoplasm! If you feel brave enough to try again: restart the game, create a new character and descened. " +
							  "It will always be waiting for you...\n" +
							  "(P.S. You died {0} time(s).)", deaths);
			Console.ReadLine();
		}
		
		public static void winnerWinner(ref User Character)
        {
			Console.WriteLine("\nCongragulations on escaping! You should be proud of yourself. If you want to try a differtn path\n" +
							  "just reload the game and try again! - Alex Garcia, 2021");
			Console.ReadLine();
			Environment.Exit(0);
        }
	}
}
