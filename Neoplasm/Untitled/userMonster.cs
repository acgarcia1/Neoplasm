using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neoplasm.Untitled
{
    public class userMonster : Being
    {
        private string name;
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        private string body;
        public string _body
        {
            get { return body; }
            set { body = value; }
        }
        private int age;
        public int _age
        {
            get { return _age; }
            set { age = value; }
        }
        public userMonster(string type)
        {
            if (type == "SPIDERS")
            {
                name = "Shelob";
                body = "spider";
                age = 545;
            }         
            else if (type == "COWS")
            {
                name = "Bertha";
                body = "large cow";
                age = 16;
            }
            else
            {
                name = "Cthulhu";
                body = "Gelatinous Slime";
                age = 100000;
            }
        }

        public override void printDetails(string name, int age, string body)
        {
            Console.WriteLine("This beast of the infite has the name {0}, has the incalcuable age of {1}, and the glorious body of a {2}. Tremble before the beast.", name, age, body);
        }
    }
}
