using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public class NimbleScientist : Nimble
	{			
		 public NimbleScientist(int userAge, string userName) : base(userAge)
		{
			Age = userAge;
			Name = userName;
		}
		
	}
}
