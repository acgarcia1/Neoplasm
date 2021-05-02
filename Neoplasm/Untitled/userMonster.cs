using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neoplasm.Untitled
{
    public class userMonster
    {
        public string name;
        public string body;      
        public userMonster(string type)
        {
            if (type == "SPIDERS")
            {
                name = "Shelob";
                body = "spider";                
            }
            else if (type == "NEEDLES")
            {
                name = "Poky";
                body = "needle";
            }
            else if (type == "COWS")
            {
                name = "Bertha";
                body = "large cow";
            }
            else
            {
                name = "Cthulhu";
                body = "Old god";
            }
        }
    }
}
