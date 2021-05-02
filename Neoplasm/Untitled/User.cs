using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neoplasm.Untitled
{
    public class User : ISecretKey, ISecretAxe, ISecretBoard
    {
        int Age { get; set; }
        string Name { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Size { get; set; }
        bool key = false;
        bool axe = false;
        bool skateBoard = false;
        
        public bool foundBoard()
        {
            return skateBoard = true;
        }
        public bool foundKey()
        {
            return key = true;
        }

        public bool foundAxe()
        {
           return axe = true;
        }

        public User ()
        {
            Age = 15;
            Name = "Bob";
            Strength = 5;
            Speed = 5;
            Size = 5;
        }

        public User(int age, string name, string build)
        {
            Age = age;
            Name = name;

            if (build == "BRAWNY")
            {
                if (age < 20)
                {
                    Strength = 9;
                    Speed = 6;
                    Size = 7;
                }
                else if (age > 20 && age < 60)
                {
                    Strength = 10;
                    Speed = 5;
                    Size = 8;
                }
                else
                {
                    Strength = 9;
                    Speed = 4;
                    Size = 6;
                }
            }
            else if (build == "NIMBLE")
            {
                if (age < 20)
                {
                    Strength = 5;
                    Speed = 10;
                    Size = 5;
                }
                else if (age > 20 && age < 60)
                {
                    Strength = 6;
                    Speed = 9;
                    Size = 6;
                }
                else
                {
                    Strength = 5;
                    Speed = 8;
                    Size = 6;
                }
            }
            else //Slight class build
            {
                if (age < 20)
                {
                    Strength = 4;
                    Speed = 7;
                    Size = 3;
                }
                else if (age > 20 && age < 60)
                {
                    Strength = 5;
                    Speed = 7;
                    Size = 4;
                }
                else
                {
                    Strength = 4;
                    Speed = 6;
                    Size = 3;
                }
            }
            
        }
    }
}
