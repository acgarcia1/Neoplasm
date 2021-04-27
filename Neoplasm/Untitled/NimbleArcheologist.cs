using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public class NimbleArcheologist : Nimble
	{
		private int ancientKnowledge;
		public NimbleArcheologist(int userAge, string userName) : base(userAge)
		{
			Age = userAge;
			Name = userName;
			ancientKnowledge = 10;
		}
	}
}
