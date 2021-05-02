using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public class Brawny : User
	{	
        public int Age { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Size { get; set; }
        

        public Brawny()
		{
			Strength = 10;
			Speed = 4;
			Size = 8;

		}
	}
}
