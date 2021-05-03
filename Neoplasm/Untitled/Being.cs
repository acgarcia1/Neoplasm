using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neoplasm.Untitled
{
    public abstract class Being
    {
        string Name;
        int Age;
        string Body;

        public abstract void printDetails(string name, int age, string body);                
        
    }
}
