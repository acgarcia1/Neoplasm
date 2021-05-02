using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public class Rooms
	{
		public static string choice;
		public static void DeathRoom()
        {
			throw new NotImplementedException();
        }
		public static void Room1(int speed, int size, int strength)
		{
			Console.WriteLine("---------------------------------------------------------------------------------------------------------\n"
							  + "---------------------------------------------------------------------------------------------------------\n");
			Console.WriteLine("You awaken in the dark. The moist smell of earth and decay fills your nose as you scramble to your feet.\n" +
							  "A torch on the wall lights without you touching it, as if it was waiting for something to awaken it.");
			Console.WriteLine("The light illuminates three doorways. The one on the left is blocked by a large stone, the middle door has a small gap underneath, " +
							   "and the door to the right has a switch next to it. What action would you like to take?\n" +
							   "- Attempt to move stone. - Try and squeeze under the gap. - Flip the switch (Answer with Left, Mid, Right)");
			choice = Console.ReadLine();
			choice = choice.ToUpper();
			if(choice == "LEFT")
            {
				if(strength >= 8)
                {
					Console.WriteLine("You saddle up to the side of the stone and push. Slowly the stone scraps aside, revealing a staircase" +
									   "that goes deeper into the earth. You descend.");
					Room8();
                }
				else
                {
					Console.WriteLine("You saddle up to the side of the stone and push. You think it moves slightly, but you can't be sure. " +
									  "You take a step back and try again, straining against the cold stone, pushing, pushing, pushing, until " +
									  "you hear a horrific snap. Your spine has fractured from the exertion, bulging out from underneath your shirt like a malignant growth." +
									  "You lie on the floor incapable of movement as your eyes slowly close.");
					EventPrint.printDeath();
                }
            }
			if(choice == "MID")
            {
				if(size <= 4)
                {
					Console.WriteLine("You get down on your hands and knees to peer under the door. Upon first inspection you feel confident you'll fit. " +
									  "You place your belly on the cold stone floor and slowly inch underneath the door. You feel something snag your shirt briefly " +
									  "and your heart begins to race before you tear it free. You make it to the other side and see a staricase descending deeper into " +
									  "the earth, with a faint glow of light around the gentle curve of the wall. You descend.");
					Room9();
                }
				else
                {
					Console.WriteLine("You get down on your hand and knees to peer under the door. Upon first inspection you feel confident you'll fit. " +
						              "You place your belly on the cold stone floor and slowly inch underneath the door. You move about six inches before " +
									  "becoming stuck. Your throat starts to close ")
                }
            }


		
		}

		public static void Room2()
		{
			throw new NotImplementedException();
		}
		public static void Room3()
        {
			throw new NotImplementedException();
        }
		public static void Room4()
        {
			throw new NotImplementedException();
        }
		public static void Room5()
        {
			throw new NotImplementedException();
        }
		public static void Room6()
        {
			throw new NotImplementedException();
        }
		public static void Room7()
        {
			throw new NotImplementedException();
        }
		public static void Room8()
        {
			throw new NotImplementedException();
        }
		public static void Room9()
        {
			throw new NotImplementedException();
        }
		public static void Room10()
        {
			throw new NotImplementedException();
        }
		public static void Room11()
        {
			throw new NotImplementedException();
        }
		public static void Room12()
        {
			throw new NotImplementedException();
        }
		public static void Room13()
        {
			throw new NotImplementedException();
        }
		public static void Room14()
        {
			throw new NotImplementedException();
        }
		public static void FinalRoom()
        {
			throw new NotImplementedException();
        }
	}
}
