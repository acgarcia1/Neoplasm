using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public class Nimble : User
	{

		public int Age { get; set; }
		public string Name { get; set; }
		public int Strength { get; set; }
		public int Speed { get; set; }
		public int Size { get; set; }

		public Nimble()
        {
			Strength = 6;
			Speed = 9;
			Size = 6;
        }

		public Nimble(int userAge)
		{
			if (userAge < 20)
            {
				Strength = 5;
				Speed = 10;
				Size = 5;
            }
			else if (userAge > 20 && userAge < 60)
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
	}
}
