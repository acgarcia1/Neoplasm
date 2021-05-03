using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neoplasm.Untitled
{
    public class finalRoom
    {
        public static string choice;
        public static string answer;
        public static void Finale(userMonster monster, User character)
        {
            Console.WriteLine("You enter the final room and see a terrible sight. Pillars soar into the\n" +
                              "mist above you. You take a moment to soak it all up, before realizing you\n" +
                              "are not alone. The rooms holds a pit with a bridge over it, waterfalls on\n" +
                              "either side. The beast trudges out of darkeness and reveals itself.\n");

            if (monster.body == "spider")
            {
                Console.WriteLine("The great beast {0} stands above you, her legs long and fangs dripping venom.\n" +
                                  "You stand paralyzed by fear for a brief moment before you take action.\n" +
                                  "To your left you see a chest, just in front of the bridge is a trampoline,\n" +
                                  "and to your right you see a smooth wall with rushing water running sides upon it.\n" +
                                  "What do you choose?\n" +
                                  "- Chest\n" +
                                  "- Trampoline\n" +
                                  "- Water wall (Top, Mid, Bottom)\n", monster.name);
                choice = Console.ReadLine();
                choice = choice.ToUpper();
                if (choice == "TOP")
                {
                    if (character.key == true)
                    {
                        Console.WriteLine("You succesfully reach the chest, put your key in, and open the crate.\n" +
                                          "With a big smile plastered on your face you pull out the bazooka, take aim,\n" +
                                          "and blow {0} away, making the room awash with innards. The doors at the back\n" +
                                          "room slowly open, revealing a gradual slope upward towards daylight. Exhausted\n" +
                                          "and releived, you begin your long walk to the land of the living.", monster.name);
                    }
                    else
                    {
                        Console.WriteLine("You reach the chest and pull up on the lid but it won't budge. {0} scurries over\n" +
                                          "to you, sinking her fangs deep into your flesh, disolving you from the inside.");
                        EventPrint.printDeath(ref character);
                    }
                }
                else if (choice == "MID")
                {
                    if (character.axe == true)
                    {
                        Console.WriteLine("You take a tremendous running start at the beast, bounce off of the trampoline,\n" +
                                          "and slice clean through it with your axe. {0} stays whole for a moment before\n" +
                                          "sliding apart, its innards coating the bridge. You look back, like the blade of\n" +
                                          "the axe, then move towards the open doors revealing sunlight. You walk back to\n" +
                                          "the land of the living.", monster.name);
                    }
                }
                else
                {
                    if (character.skateBoard == true)
                    {
                        Console.WriteLine("You kick of the ground and fly towards the wall to your right. You kick up and onto the wall,\n" +
                                          "letting the water carry you around the beast. Once you are positioned directly behing {0},\n" +
                                          "you launch of the wall, take the board in your hands, and cave the beasts skull in. You look\n" +
                                          "in disgust on the lifeless body, then work your way towards the sunlight indicating freedom\n" +
                                          "at the back of the room");
                    }
                    else
                    {
                        Console.WriteLine("You run towards the wall and attempt to run along it using the water for a boost.\n" +
                                          "You take one step before slipping, cracking you back on the lip of the pit, and falling\n" +
                                          "down into the depths where the beast nurtures their young.");
                        EventPrint.printDeath(ref character);
                    }
                }
            }

            else if (monster.body == "large cow")
            {
                Console.WriteLine("The great beast {0} stands above you, her large udder dangling in front of you.\n" +
                                "You stand paralyzed by fear for a brief moment before you take action.\n" +
                                "To your left you see a chest, just in front of the bridge is a trampoline,\n" +
                                "and to your right you see a smooth wall with rushing water running sides upon it.\n" +
                                "What do you choose?\n" +
                                "- Chest\n" +
                                "- Trampoline\n" +
                                "- Water wall (Top, Mid, Bottom)\n", monster.name);
                choice = Console.ReadLine();
                choice = choice.ToUpper();
                if (choice == "TOP")
                {
                    if (character.key == true)
                    {
                        Console.WriteLine("You succesfully reach the chest, put your key in, and open the crate.\n" +
                                          "With a big smile plastered on your face you pull out the bazooka, take aim,\n" +
                                          "and blow {0} away, making the room awash with innards. The doors at the back\n" +
                                          "room slowly open, revealing a gradual slope upward towards daylight. Exhausted\n" +
                                          "and releived, you begin your long walk to the land of the living.", monster.name);
                    }
                    else
                    {
                        Console.WriteLine("You reach the chest and pull up on the lid but it won't budge. {0} bounds over\n" +
                                          "to you, and drowns you in milk from her udders while letting out a triumphant\n" +
                                          "\"MOOOOOOOOOOO!\"");
                        EventPrint.printDeath(ref character);
                    }
                }
                else if (choice == "MID")
                {
                    if (character.axe == true)
                    {
                        Console.WriteLine("You take a tremendous running start at the beast, bounce off of the trampoline,\n" +
                                          "and slice clean through it with your axe. {0} stays whole for a moment before\n" +
                                          "sliding apart, its innards coating the bridge. You look back, say \"Got Milk?\",  and lick the blade of\n" +
                                          "the axe while moving towards the open doors revealing sunlight. You walk back to\n" +
                                          "the land of the living.", monster.name);
                    }
                }
                else
                {
                    if (character.skateBoard == true)
                    {
                        Console.WriteLine("You kick of the ground and fly towards the wall to your right. You kick up and onto the wall,\n" +
                                          "letting the water carry you around the beast. Once you are positioned directly behing {0},\n" +
                                          "you launch of the wall, take the board in your hands, and cave the beasts skull in. You look\n" +
                                          "in disgust on the lifeless body, then work your way towards the sunlight indicating freedom\n" +
                                          "at the back of the room");
                    }
                    else
                    {
                        Console.WriteLine("You run towards the wall and attempt to run along it using the water for a boost.\n" +
                                          "You take one step before slipping, cracking you back on the lip of the pit, and falling\n" +
                                          "down into the depths where the beast nurtures their young.");
                        EventPrint.printDeath(ref character);
                    }
                }
            }
            else
            {
                Console.WriteLine("In the final room the great lord Cthulhu awaits, legs crossed and arms tucked into a\n" +
                                  "meditative trance. The great beasts eyes peel open, and they lock onto you. \"I have but\n" +
                                  "a simple riddle to test you child. Answer correctly and return home, answer wrong, and you\n" +
                                  "shall be my eternal subject. In a room there are 53 bicycles, a table, and a dead man.\n" +
                                  "What was his crime?\n");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if(answer == "CHEATING" || answer == "CHEAT" || answer == "CARD COUNTER" || answer == "CHEATING AT POKER")
                {
                    Console.WriteLine("Cthulhu smiles, pleased with your answer. You begin to feel sleepy and fall forward\n" +
                                      "onto one of his mighty tentacles. You sleep. When you awake you are in your own bed\n" +
                                      "with the familiar sounds of the city outside. You go to get up, thinking it was all a\n" +
                                      "dream, but are stopped by a terrible pain on your chest. You rip off your shirt to reveal\n" +
                                      "large circular wounds that look like they were caused by suckers. You stare at your chest\n" +
                                      "for a moment. Your gaze slowly moves to the window, and you watch the curtain dance in the breeze.");
                }
                else
                {
                    Console.WriteLine("Cthulhu smiles, and slams a great arm down upon your head, killing you instantly. He wasn't pleased with your answer.");
                    EventPrint.printDeath(ref character);
                }

            }
        }
    }
}

