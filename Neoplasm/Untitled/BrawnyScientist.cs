using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public class BrawnyScientist : Brawny
	{      
        public BrawnyScientist(int age, string name) : base()
        {          
            Age = age;
            Name = name;
            
        }

        public BrawnyScientist()
		{
			throw new NotImplementedException();
		}

	}
}
