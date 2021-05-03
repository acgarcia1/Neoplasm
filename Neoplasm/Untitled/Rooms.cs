using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public class Rooms
	{
		public static string choice;
		public static string secondC;
		
		public static void Room1(int speed, int size, int strength, ref User character)
		{
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------\n"+
							  "----------------------------------------------------------------------------------------------------------------------------\n");
			Console.WriteLine("You awaken in the dark. The moist smell of earth and decay fills your nose as you scramble to your feet.\n" +
							  "A torch on the wall lights without you touching it, as if it was waiting for something to awaken it.");
			Console.WriteLine("The light illuminates three doorways. The one on the left is blocked by a large stone, the middle door has a small gap underneath,\n" +
							   "and the door to the right has a switch next to it. What action would you like to take?\n" +
							   "- Attempt to move stone.\n" +
							   "- Try and squeeze under the gap.\n" +
							   "- Flip the switch (Answer with Top, Mid, Bottom)");
			choice = Console.ReadLine();
			choice = choice.ToUpper();			

			if(choice == "TOP")
            {
				if(strength >= 8)
                {
					Console.WriteLine("You saddle up to the side of the stone and push. Slowly the stone scraps aside, revealing a staircase" +
									   " that goes deeper into the earth. You descend.\n");
					Room3(ref character);
                }
				else
                {
					Console.WriteLine("You saddle up to the side of the stone and push. You think it moves slightly, but you can't be sure.\n" +
									  "You take a step back and try again, straining against the cold stone, pushing, pushing, pushing, until\n" +
									  "you hear a horrific snap. Your spine has fractured from the exertion, bulging out from underneath your shirt like a malignant growth.\n" +
									  "You lie on the floor incapable of movement as your eyes slowly close.\n");
					EventPrint.printDeath(ref character);
                }
            }
			else if (choice == "MID")
            {
				if(size <= 4)
                {
					Console.WriteLine("You get down on your hands and knees to peer under the door. Upon first inspection you feel confident you'll fit.\n" +
									  "You place your belly on the cold stone floor and slowly inch underneath the door. You feel something snag your shirt briefly\n" +
									  "and your heart begins to race before you tear it free. You make it to the other side and see a staricase descending deeper into\n" +
									  "the earth, with a faint glow of light around the gentle curve of the wall. You descend.\n");
					Room9(ref character);
                }
				else
                {
					Console.WriteLine("You get down on your hand and knees to peer under the door. Upon first inspection you feel confident you'll fit.\n" +
									  "You place your belly on the cold stone floor and slowly inch underneath the door. You move about six inches before\n" +
									  "becoming stuck. Your throat starts to close and before you can choke out a word the door above you crashes down,\n" +
									  "slicing through your body like tissue paper, leaving half of your body on either side.\n");
					EventPrint.printDeath(ref character);
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
									  "you start heading down.\n");
					Room2(ref character);
                }
                else
                {
					Console.WriteLine("You cautiously step over to the switch and flick it. The door quickly opens, then shuts with a gust of air pushing you back.\n" +
									  "Undeterred, you flip the switch again, counting two seconds as it open then shuts. Nodding your head you grind your feet into\n" +
									  "the floor while leaning towards the door. You flip the switch one more time, already sprinting as you do. You dive through the\n" +
									  "door and for the briefest of moments you believe you made it through, until the weight of the door lands on your shines, splintering\n" +
									  "the bones and severing your lower legs. Blood slowly pools around you, seeping into your clothes as you fade away into nothing.\n");
					EventPrint.printDeath(ref character);

				}
            }

		
		}

		public static void Room2(ref User character)
		{
			Console.WriteLine("At the bottom of the stairs you find another room, long and rectangular. You see a wriggling on the far wall and creep forward to take a\n" +
							  "closer look. You lean in and see small black worms slithering out of pores in the walls and congregating into shapes. Into words.\n" +
							  "You take a step back to read the sign: \"Here we have a speedster, quick enough to get under the door. But are you fast\n" +
							  "enough?\" As soon as your eyes read the last word four vents in the ceiling of the room open and the room\n" +
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
				
				secondC = Console.ReadLine();
				secondC = secondC.ToUpper();
				if(secondC == "MID")
                {
					Console.WriteLine("You stand up and flick the switch on the left wall. A door opens underneath the writing. It can't be that easy, you\n" +
									  "think to yourself, but it is. You run through the door and it closes behind you, cutting off the water that runs down\n" +
									  "the ramp in front of you. You look down at the skateboard, shrug, then ride it down the ramp.\n");
					Console.ReadLine();
					Room10(ref character);
                }
				else
                {
					Console.WriteLine("You grab a few larger rocks and pile them together as the water pools at your feet. Standing on top of them allows you\n" +
									  "to just reach the skylight. You break it open with the skateboard and are welcomed by a vat of acid that instantly\n" +
									  "melts your eyeballs onto your brainstem. Your body falls into the water and floats among the rubble. The worms from\n" +
									  "the wall slowly make their way towards you.\n");
					EventPrint.printDeath(ref character);
                }
            }
			else if(choice == "MID")
            {
				Console.WriteLine("You stand up and flick the switch on the left wall. A door opens underneath the writing. It can't be that easy, you\n" +
								  "think to yourself, but it is. You run through the door and it closes behind you, cutting off the water that runs down\n" +
								  "the ramp in front of you. You shrug and continue on down the ramp.\n");
				Console.ReadLine();
				Room10(ref character);
            }
            else
            {
				Console.WriteLine("You grab a few larger rocks and pile them together as the water pools at your feet. Standing on top of them allows you\n" +
									  "to just reach the skylight. You break it open with the skateboard and are welcomed by a vat of acid that instantly\n" +
									  "melts your eyeballs onto your brainstem. Your body falls into the water and floats among the rubble. The worms from\n" +
									  "the wall slowly make their way towards you.\n");
				EventPrint.printDeath(ref character);
            }
			
		}
		public static void Room3(ref User character)
        {
			Console.WriteLine("You enter a square room with a large rock in the middle. A voice from deep within the earth rumbles:\n" +
							  "\"Strength is your strong suit it seems. Can it save you now?\" You take another look and see a door with\n" +
							  "a switch, and a panel with a crack in it. What will you do:\n" +
							  "- Attempt to lift the large rock in the center of the room.\n" +
							  "- Punch the cracked panel.\n" +
							  "- Flip the switch. (Top, Mid, Bottom)");
			choice = Console.ReadLine();
			choice = choice.ToUpper();
			if(choice == "TOP")
            {
				Console.WriteLine("You easily lift the rock and reveal a whole in the floor. Since there is no tomorrow if you don't get out\n" +
								  "you jump in only to find yourself in a pit full of snakes. You try and claw your way out, punching a few snakes\n" +
								  "in the mouth along the way, but you eventually succumb to the bites and die.\n");
				EventPrint.printDeath(ref character);
            }
			else if(choice == "MID")
            {
				Console.WriteLine("You wind up and punch the panel, revealing an ancient axe with vines wrapped around the handle. You retrieve it\n" +
								  "the hole in the wall, feel its weight, and consider your other options. (Top, Bottom)");
				character.foundAxe();

				secondC = Console.ReadLine();
				secondC = secondC.ToUpper();
				if (secondC == "TOP")
                {
					Console.WriteLine("You easily lift the rock and reveal a whole in the floor. Since there is no tomorrow if you don't get out\n" +
								  "you jump in only to find yourself in a pit full of snakes. You try and claw your way out, punching a few snakes\n" +
								  "in the mouth along the way, but you eventually succumb to the bites and die.\n");
					EventPrint.printDeath(ref character);
                }
				else
                {
					Console.WriteLine("You flip the switch and a door opens up on the wall in front of you. You can't believe that it would be\n" +
									  "that easy, but it is. You saunter through the door, prepared for whatever is next.\n");
					Room13(ref character);
                }
            }
			else
            {
				Console.WriteLine("You flip the switch and a door opens up on the wall in front of you. You can't believe that it would be\n" +
									  "that easy, but it is. You saunter through the door, prepared for whatever is next.\n");
				Room13(ref character);
            }
        }		
		public static void Room9(ref User character)
        {
			Console.WriteLine("You enter a room with a 5ft ceiling, but thankfully you don't have to stoop. You see:\n" +
							  "- a glint of light in the corner of the room\n" +
							  "- a door with a switch\n" +
							  "- a crack in the wall to your right. (Top, Mid, Bottom)");
			choice = Console.ReadLine();
			choice = choice.ToUpper();
			if(choice == "TOP")
            {
				Console.WriteLine("You walk over the the corner of the room, move a small pile of rocks aside\n" +
								  "and find a golden key resting against the floor. You pick it up and put it\n" +
								  "in your pocket before considering your other options. (Mid, Bottom)");
				character.foundKey();

				secondC = Console.ReadLine();
				secondC = secondC.ToUpper();
				if(secondC == "MID")
                {
					Console.WriteLine("You flip the switch next to the door and stare suspiciously as it opens.\n" +
									  "Not one to throw away a good thing you move through the door and onto the\n" +
									  "next task.\n");
					Room14(ref character);
                }
				else
                {
					Console.WriteLine("You attempt to squeeze through the crack in the wall and make it a good way\n" +
								  "before getting stuck. Unable to move forward or back you begin to panic. You\n" +
								  "hear a slithering noise ahead of you, and a tendril of filth from deep underground\n" +
								  "grabs you by your torso and pulls you forcefully into the crevice. Your bones crack\n" +
								  "and skins peels off until you no longer pull breath, but the tendril pulls on towards\n" +
								  "its final destination.\n");
                }
            }
			else if(choice == "MID")
            {
				Console.WriteLine("You flip the switch next to the door and stare suspiciously as it opens.\n" +
									  "Not one to throw away a good thing you move through the door and onto the\n" +
									  "next task.\n");
				Room14(ref character);
            }
			else
            {
				Console.WriteLine("You attempt to squeeze through the crack in the wall and make it a good way\n" +
								  "before getting stuck. Unable to move forward or back you begin to panic. You\n" +
								  "hear a slithering noise ahead of you, and a tendril of filth from deep underground\n" +
								  "grabs you by your torso and pulls you forcefully into the crevice. Your bones crack\n" +
								  "and skins peels off until you no longer pull breath, but the tendril pulls on towards\n" +
								  "its final destination.");
				EventPrint.printDeath(ref character);
            }
        }
		public static void Room10(ref User character)
        {
			Console.WriteLine("You enter the next room and all of your exposed hair is instantly burned off of your body.\n" +
							  "The room is home to a pit of lava, over which rides a single round bar. The tumescent voice\n" +
							  "once again rises around you: \"You survived another room. I am pleased. But now you must shred!\"");
			if(character.skateBoard == true)
            {
				Console.WriteLine("You grin as you understand the sweet meaning behind those words. You throw the skateboard down\n" +
								  "back up a bit, and kick off towards the pit. You sail above it gracefully and come down hard on\n" +
								  "the pipe, grinding across the expanse with sparks flying and the air rushing past wisking away\n" +
								  "your sweat. You make it to the other side, do a kickflip, and hurry down the ramp to what you know\n" +
								  "is the final test.\n");
				
            }
			else
            {
				Console.WriteLine("You begin to sweat. If you had a board shredding would be a given, but you find yourself standing\n" +
								  "alone, hands empty aside from sweat. You step out onto the pipe, arms extending to keep your balance.\n" +
								  "You make it about four steps before you slip and fall, coming down hard with a leg on either side of\n" +
								  "the pipe. You let out one pitiful word \"Momma\", before sliding off into the lava, burning as you reach\n" +
								  "towards help that isn't coming.");
				EventPrint.printDeath(ref character);
				
            }
        }				
		public static void Room13(ref User character)
        {
			Console.WriteLine("You enter a room with ancient trees growing from the floor, the ceiling far out of reach. At the far end\n" +
							  "is a wooden door. The voice returns \"I must AXE you a question. Are you strong enough to get through my\n" +
							  "door?\"\n");
			if(character.axe == true)
            {
				Console.WriteLine("You look down at the axe in your hand and smile. All those days chopping cherry trees on the acerage\n" +
								  "were about to come in handy. You pick up speed as you run towards the door raising the axe above your\n" +
								  "head. You bring it down with a tremendous WACK on the door, instantly turning it into sawdust. This\n" +
								  "pleases you, as you stroll through the open door, ready for whatever came next.\n");
				
            }
			else
            {
				Console.WriteLine("Not understanding the reason for the pun, you take off running towards the door. You leap into the\n" +
								  "air and come down with a terrific karate chop on the door. There is a moment of stillness before your\n" +
								  "hand erupts in a fountain of blood. Horrified, you stare at your hand as you back into one of the trees.\n" +
								  "The bark suddenly opens to take you in, your body transformed into food for this ancient forest just like\n" +
								  "so many before you.\n");
				EventPrint.printDeath(ref character);
				

            }
        }
		public static void Room14(ref User character)
        {
			Console.WriteLine("You enter the next room to find a garden party being held by the local critters, those that are know to\n" +
							  "frequent underground labyrinths. You see a small table set up in the middle of the room with a keyhole\n" +
							  "in the middle.");
			if(character.key == true)
            {
				Console.WriteLine("Without hesitation you stick the golden key you found into the lock and turn. It opens to reveal\n" +
								  "a narrow stone slide going down. One particularly brave silverfish nudges you forward, and you take\n" +
								  "a jump down the slide, mentally preparing for whatever comes next.\n");
				Console.ReadLine();
				
            }
			else
            {
				Console.WriteLine("Confused, you stick your finger into the lock, only for it to clamp down on your finger. The local\n" +
								  "begin to chirp and growl, upset at your folly. They quickly cover your body and strip it to the bone\n" +
								  "leaving nothing but picked over remnants of what was once a human being.\n");
				EventPrint.printDeath(ref character);
				
            }
        }		
	}
}
