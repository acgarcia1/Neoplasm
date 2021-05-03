using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neoplasm.Untitled
{
    public class User : Being, ISecretKey, ISecretAxe, ISecretBoard
    {
        private int Age;
        public int _userAge
        {
            get { return Age; }
            set { Age = value; }
        }
        private string Name;
        public string _Name 
        {
            get {return Name;}
            set { Name = value; }
        }   
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Size { get; set; }
        public bool key = false;
        public bool axe = false;
        public bool skateBoard = false;
        public int deaths { get; set; }

        public override void printDetails(string name, int age, string body)
        {
            Console.WriteLine("The characters name is {0}, its body is {1}, and they are {2} years old. Tremble.", name, body, age);
        }
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
            _userAge = 15;
            _Name = "Bob";
            Strength = 5;
            Speed = 5;
            Size = 5;
        }

        public User(int age, string name, string build)
        {
            _userAge = age;
            _Name = name;
            deaths = 0;

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
            else //Slight class build, also handles random input
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
