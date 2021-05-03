using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public class Rooms
	{
		public static string choice;
		public static string secondC;
		public static void DeathRoom()
        {
			throw new NotImplementedException();
        }
		public static void Room1(int speed, int size, int strength, User character)
		{
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------\n"+
							  "----------------------------------------------------------------------------------------------------------------------------\n");
			Console.WriteLine("You awaken in the dark. The moist smell of earth and decay fills your nose as you scramble to your feet.\n" +
							  "A torch on the wall lights without you touching it, as if it was waiting for something to awaken it.");
			Console.WriteLine("The light illuminates three doorways. The one on the left is blocked by a large stone, the middle door has a small gap underneath,\n" +
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
					Room13();
                }
				else
                {
					Console.WriteLine("You saddle up to the side of the stone and push. You think it moves slightly, but you can't be sure.\n" +
									  "You take a step back and try again, straining against the cold stone, pushing, pushing, pushing, until\n" +
									  "you hear a horrific snap. Your spine has fractured from the exertion, bulging out from underneath your shirt like a malignant growth.\n" +
									  "You lie on the floor incapable of movement as your eyes slowly close.");
					EventPrint.printDeath();
                }
            }
			else if (choice == "MID")
            {
				if(size <= 4)
                {
					Console.WriteLine("You get down on your hands and knees to peer under the door. Upon first inspection you feel confident you'll fit.\n" +
									  "You place your belly on the cold stone floor and slowly inch underneath the door. You feel something snag your shirt briefly\n" +
									  "and your heart begins to race before you tear it free. You make it to the other side and see a staricase descending deeper into\n" +
									  "the earth, with a faint glow of light around the gentle curve of the wall. You descend.");
					Room9();
                }
				else
                {
					Console.WriteLine("You get down on your hand and knees to peer under the door. Upon first inspection you feel confident you'll fit.\n" +
									  "You place your belly on the cold stone floor and slowly inch underneath the door. You move about six inches before\n" +
									  "becoming stuck. Your throat starts to close and before you can choke out a word the door above you crashes down,\n" +
									  "slicing through your body like tissue paper, leaving half of your body on either side.");
					EventPrint.printDeath();
                }
            }
			else
            {
				if(speed >= 8)
                {
					Console.WriteLine("You cautiously step over to the switch and flick it. The door quickly opens, then shuts with a gust of air pushing you back.\n" +
									  "Undeterred, you flip the switch again, counting two seconds as it open then shuts. Nodding your head you grind your feet into\n" +
									  "the floor while leaning towards the door. You flip the switch one more time, already sprinting as you do. You dive through the\n" +
									  "door as it crashes down behind you. You peer through the settling dust, see a set of stairs going deeper into the earth, and\n" +
									  "you start heading down.");
					Room2(character);
                }
                else
                {
					Console.WriteLine("You cautiously step over to the switch and flick it. The door quickly opens, then shuts with a gust of air pushing you back.\n" +
									  "Undeterred, you flip the switch again, counting two seconds as it open then shuts. Nodding your head you grind your feet into\n" +
									  "the floor while leaning towards the door. You flip the switch one more time, already sprinting as you do. You dive through the\n" +
									  "door and for the briefest of moments you believe you made it through, until the weight of the door lands on your shines, splintering\n" +
									  "the bones and severing your lower legs. Blood slowly pools around you, seeping into your clothes as you fade away into nothing.");
					EventPrint.printDeath();

				}
            }

		
		}

		public static void Room2(User character)
		{
			Console.WriteLine("At the body of the stairs you find another room, long and rectangular. You see a wriggling on the far wall and creep forward to take a\n" +
							  "closer look. You lean in and see small black worms slithering out of pores in the walls and congregating into shapes. Into words.\n" +
							  "You take a step back to read the sign: Here we have a speedster, quick enough to get under the door. But are you fast\n" +
							  "enough in water too?. As soon as your eye reads the last word four vents in the ceiling of the room open and the room\n" +
							  "begins to fill with water. You see three options ahead.\n" +
							  "- There is a panel with a small crack in it on the floor that you can attempt to open.\n" +
							  "- There is a switch on the left wall.\n" +
							  "- There is a skylight in reach if you stack some stones togethether. (Top, Mid, Bottom)");
			choice = Console.ReadLine();
			choice = choice.ToUpper();
			if(choice == "TOP")
            {
				Console.WriteLine("You reach into the crack and pull. The panel slowly peels open to reveal an ancient skateboard with a faded photo of Tony Hawk\n" +
								  "plastered on it. You retrieve it and reconsider the other options. (Mid, Bottom)");
				character.foundBoard();
				Console.WriteLine(character.skateBoard);
				secondC = Console.ReadLine();
				secondC = secondC.ToUpper();
				if(secondC == "MID")
                {
					Console.WriteLine("You stand up and flick the switch on the left wall. A door opens underneath the writing. It can't be that easy, you\n" +
									  "think to yourself, but it is. You run through the door and it closes behind you, cutting off the water that runs down\n" +
									  "the ramp in front of you. You look down at the skateboard, shrug, then ride it down the ramp.");
					Room10(character);
                }
				else
                {
					Console.WriteLine("You grab a few larger rocks and pile them together as the water pools at your feet. Standing on top of them allows you\n" +
									  "to just reach the skylight. You break it open with the skateboard and are welcomed by a vat of acid that instantly\n" +
									  "melts your eyeballs onto your brainstem. Your body falls into the water and floats among the rubble. The worms from\n" +
									  "the wall slowly make their way towards you.");
					EventPrint.printDeath();
                }
            }
			else if(choice == "MID")
            {
				Console.WriteLine("You stand up and flick the switch on the left wall. A door opens underneath the writing. It can't be that easy, you\n" +
								  "think to yourself, but it is. You run through the door and it closes behind you, cutting off the water that runs down\n" +
								  "the ramp in front of you. You shrug and continue on down the ramp.");
				Room10(character);
            }
            else
            {
				Console.WriteLine("You grab a few larger rocks and pile them together as the water pools at your feet. Standing on top of them allows you\n" +
									  "to just reach the skylight. You break it open with the skateboard and are welcomed by a vat of acid that instantly\n" +
									  "melts your eyeballs onto your brainstem. Your body falls into the water and floats among the rubble. The worms from\n" +
									  "the wall slowly make their way towards you.");
				EventPrint.printDeath();
            }
			
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
		public static void Room10(User character)
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
