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

		public static void printGoodbye()
		{
			Console.WriteLine("Thank you for playing Neoplasm! If you feel brave enough to try again: restart the game, create a new character, and descened. " +
							  "It will always be waiting for you...");
			Console.ReadLine();
		}
	}
}
